# 服务终结点

在 Serenity 中，服务终结点是 ASP.NET MVC 控制器的一个子类。

这是 Northwind 的 OrderEndpoint 摘录：

```cs
namespace Serene.Northwind.Endpoints
{
    [RoutePrefix("Services/Northwind/Order"), Route("{action}")]
    [ConnectionKey("Northwind"), ServiceAuthorize(Northwind.PermissionKeys.General)]
    public class OrderController : ServiceEndpoint
    {
        [HttpPost]
        public SaveResponse Create(IUnitOfWork uow, SaveRequest<MyRow> request)
        {
            return new MyRepository().Create(uow, request);
        }

        public ListResponse<MyRow> List(IDbConnection connection, ListRequest request)
        {
            return new MyRepository().List(connection, request);
        }
    }
}
```


### 控制器的命名和命名空间

即使文件名为 *OrderEndpoint.cs*，但我们的类名称却是 *OrderController*。这是由于 ASP.NET MVC 的限制（我找不到之所以这样的逻辑）：所有控制器必须以 *Controller* 后缀结尾。

如果控制器类名称不以此后缀结束，行为（action）将根本不能工作。所以要非常小心。

> 这个错误我也犯了几次并花了我个小时。

类的命名空间 (*Serene.Northwind.Endpoints*) 就不是那么重要了，但我们通常把终结点放在 *MyProject.Module.Endpoints* 命名空间下，以保持一致性。

OrderController 继承自 ServiceEndpoint（也应该），从而为该 MVC 控制器提供不太常用的功能，我们很快就会介绍这些功能。


### 路由特性

```cs
[RoutePrefix("Services/Northwind/Order"), Route("{action}")]
```
上面的路由特性属于 ASP.NET 路由特性，为服务终结点配置基本地址。我们的行为将使用 "mysite.com/Services/Northwind/Order" 获得。

> 请避免经典 ASP.NET MVC 路由，它把所有路由放在 ApplicationStart 方法用 *routes.AddRoute* 等配置。这样真的很难管理。

Serenity 的所有服务终结点默认使用 */Services/Module/Entity* 寻址方案。即使你依然能够使用另一套寻址方案，但建议保持一致性并遵守基本约定。


### ConnectionKey 特性

该特性指定在创建连接时，应该使用应用程序配置文件 (如 web.config) 中的哪个连接键。

让我们看看如何以及何时使用它来自动创建连接：

```cs
public ListResponse<MyRow> List(IDbConnection connection, ListRequest request)
{
    return new MyRepository().List(connection, request);
}
```

在这里我们看到该操作需要一个 IDbConnection 参数，但不能从客户端发送 IDbConnection 到 MVC 的行为（action）。所以由谁来创建该连接？

还记得我们的控制器是继承 ServiceEndpoint 吗？因此 ServiceEndpoint 可以知道我们的行为需要连接，它会检查控制器类的 [ConnectionKey] 特性来确定连接键，然后使用 *SqlConnections.NewByKey()* 创建一个连接，并用此连接执行我们的行为，当行为执行结束时，关闭连接。

可以从行为中删除此连接参数并手动创建它：

```cs
public ListResponse<MyRow> List(ListRequest request)
{
    using (var connection = SqlConnections.NewByKey("Northwind")) 
    {
        return new MyRepository().List(connection, request);
    }
}
```

实际上 ServiceEndpoint 在幕后为我们创建连接。

为什么不使用此功能，而让平台自动处理这个细节呢？其中一个原因是：你可能需要打开一个未列在配置文件中的自定义连接，或根据某些条件打开一个动态连接。

我们有另一种方法，它需要 IUnitOfWork（事务）而不是 IDbConnection 参数：

```cs
public SaveResponse Create(IUnitOfWork uow, SaveRequest<MyRow> request)
{
    return new MyRepository().Create(uow, request);
}
```

这里的情况是类似的。ServiceEndpoint 创建另一个连接，但这次它(IUnitOfWork) 在该连接启动一个事务来调用我们的行为方法，并在返回时自动提交事务。如果执行失败，将回滚。

这是同一件事的手动版：

```cs
public SaveResponse Create(SaveRequest<MyRow> request)
{
    using (var connection = SqlConnections.NewByKey("Northwind"))
    using (var uow = new UnitOfWork(connection))
    {
        var result = new MyRepository().Create(uow, request);
        uow.Commit();
        return result;
    }
}
```

因此，ServiceEndpoint 用 1 行代码处理 8 行代码的逻辑。


### 何时使用 IUnitOfWork / IDbConnection

按照惯例，修改一些状态 （创建、 更新等） 的 Serenity 操作方法应该在内部使用事务，因此需要使用 IUnitOfWork 参数，而那些只读操作（列表、检索）应该使用 IDbConnection。

如果服务方法含 IUnitOfWork 参数，则表明你的方法将修改一些数据。

### 关于 [HttpPost] 特性

你可能已经注意到创建(Create)，更新(Update)，删除(Delete)等方法具有此特性，而列表(List)、检索(Retrieve)等方法不包含该特性。

此特性限制创建、更新、删除操作只能使用 HTTP POST ，而不允许它们由 HTTP GET 调用。

因为这些方法修改状态，例如从 DB 插入、更新、删除一些记录，所以它们不应该被无意中调用，并且它们的结果不应该被允许缓存。

> 这也带来一些安全隐患。GET 方法的行为可能会受到一些攻击。

列表、检索不会修改任何状态，因此它们允许使用 GET 调用，如：在浏览器的地址栏调用。

即使列表、检索可以通过 GET 调用，Serenity 总是使用 HTTP POST 调用服务（如 Q.CallService），并启用缓存，以避免出现意外的结果。


### ServiceAuthorize 特性

我们的控制器类有 ServiceAuthorize 特性：

```
ServiceAuthorize(Northwind.PermissionKeys.General)
```

该特性类似于  ASP.NET MVC 的 [Authorize] 特性，但它只检查用户是否已登录，若没有登录则抛出异常。

如果使用时不带参数（如 [ServiceAuthorize()]），此属性也会检查该用户是否已登录。

当你把访问许可键(permission key) 字符串传递给它时，它会检查该用户是否已登录且具有该权限。

```
ServiceAuthorize("SomePermission")
```

如果用户未被授予 "SomePermission"，则阻止他执行任何终结点的方法。

[PageAuthorize] 特性也类似，但你可能更喜欢在服务终结点使用 [ServiceAuthorize] 特性，因为它的错误处理更适合服务。

虽然 [PageAuthorize] 将用户 **重定向** 到登录页面，但如果用户没有权限，ServiceAuthorize 返回一个更适合的 **未授权的服务错误**。

也可以在行为中使用 [ServiceAuthorize] 特性，而不只在控制器中使用该特性：

```cs
[ServiceAuthorize("SomePermissionThatIsRequiredForCreate")]
public SaveResponse Create(SaveRequest<MyRow> request)
```


### 关于  Request 和 Response 对象

除了特殊处理的 IUnitOfWork 和 IDbConnection 参数，所有 Serenity 服务行为都是单个请求参数并返回单个结果。 

```
public SaveResponse Create(IUnitOfWork uow, SaveRequest<MyRow> request)
```

让我们从返回结果开始。如果你有使用 ASP.NET MVC 的背景，你会知道控制器不能返回任意对象。它们必须返回一个派生自 *ActionResult* 的对象。

但是我们的 *SaveResponse* 派生自 *ServiceResponse*，它只是一个普通的对象：

```
public class SaveResponse : ServiceResponse
{
    public object EntityId;
}

public class ServiceResponse
{
    public ServiceError Error { get; set; }
}
```

这怎么可能？还是 ServiceEndpoint 在幕后处理这些细节。它把 SaveResponse 转换为指定行为返回 JSON 数据的结果。 

只要响应对象是从 ServiceResponse 派生并且是可序列化成 JSON，我们就不必担心这些细节。

我们的请求对象也是一个普通的类，派生自基本的 ServiceRequest 类：

```cs
public class SaveRequest<TEntity> : ServiceRequest, ISaveRequest
{
    public object EntityId { get; set; }
    public TEntity Entity { get; set; }
}

public class ServiceRequest
{
} 
```

ServiceEndpoint 的 HTTP 请求内容通常是 JSON，若要将其反序列化为我们的 *请求* 参数，需要使用特殊的 MVC 操作过滤器(JsonFilter)。

如果想使用一些自定义的操作，你的方法也应该遵循这一理念，如：只有一个请求（派生自 ServiceRequest）并返回一个响应（派生自 ServiceResponse）。

让我们添加一个服务方法，让其返回所有订单总数大于某一数量的订单：

```
public class MyOrderCountRequest : ServiceRequest
{
    public decimal MinAmount { get; set; }
}

public class MyOrderCountResponse : ServiceResponse
{
    public int Count { get; set; }
}

public class OrderController : ServiceEndpoint
{
    public MyOrderCountResponse MyOrderCount(IDbConnection connection, 
        MyOrderCountRequest request)
    {
        var fld = OrderRow.Fields;
        return new MyOrderCountResponse 
        {   
            Count = connection.Count<OrderRow>(fld.TotalAmount >= request.MinAmount);
        };
    }
}
```

请遵循这种模式并不要尝试向操作方法添加更多的参数。Serenity 遵循只有一个请求对象的基本消息模式，以便后继的扩展可添加更多的属性。

不要这样做（被称为 RPC 风格。RPC, Remote procedure call：远程过程调用）：

```cs
public class OrderController : ServiceEndpoint
{
    public decimal MyOrderCount(IDbConnection connection, 
        decimal minAmount, decimal maxAmount, ....)
    {
        // ...
    }
}
```

更佳的做法是（基于消息服务）：

```cs
public class MyOrderCountRequest : ServiceRequest
{
    public decimal MinAmount { get; set; }
    public decimal MaxAmount { get; set; }
}

public class OrderController : ServiceEndpoint
{
    public MyOrderCountResponse MyOrderCount(IDbConnection connection, 
        MyOrderCountRequest request)
    {
        // ...
    }
}
```

这可以避免记忆参数的顺序，使你的请求对象更具扩展性而又不破坏向后的兼容性，还有更多你可能后来才会注意到的优点。


### 为什么 Endpoint 方法几乎都是空的？

我们通常将实际工作委托给仓储层：

```cs
public ListResponse<MyRow> List(IDbConnection connection, ListRequest request)
{
    return new MyRepository().List(connection, request);
}
```

记住，ServiceEndpoint 直接依赖于 ASP.NET MVC。这意味着你在 ServiceEndpoint 写的任何代码将依赖于 ASP.NET MVC，因此需要 web 环境。

你可能不能重用任何写在这里的代码，比如重用一个桌面应用程序的代码。否则就不能将此代码独立为一个 DLL，它并不具有对 WEB 库引用的任何代码。

但如果你真的没有这样的需求，你可以删除所有的仓储及所有在终结点内部编写的代码。

有些人可能认为：实体、仓储、 业务规则、终结点等都应该在自己独立的程序集中。从理论上及某些情况下，这可能是有效的，但有些（或大部分）的用户不需要这么多的程序集，且可能落入 YAGNI（YAGNI, you aren't gonna need it ：你不会需要它） 类别。
