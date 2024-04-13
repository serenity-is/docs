# Service Endpoints

In Serenity, service endpoints are a subclass of ASP.NET Core controllers.

Here is an excerpt from UserEndpoint:

```cs
using MyRow = MyProject.Administration.UserRow;

namespace MyProject.Administration.Endpoints;

[Route("Services/Administration/User/[action]")]
[ConnectionKey(typeof(MyRow)), ServiceAuthorize(typeof(MyRow))]
public class UserEndpoint : ServiceEndpoint
{
    [HttpPost, AuthorizeCreate(typeof(MyRow))]
    public SaveResponse Create(IUnitOfWork uow, SaveRequest<MyRow> request, 
        [FromServices] IUserSaveHandler handler)
    {
        return handler.Create(uow, request);
    }

    //...
   
    public ListResponse<MyRow> List(IDbConnection connection, UserListRequest request,
        [FromServices] IUserListHandler handler)
    {
```

### Controller Naming and Namespace

The endpoint class above is named *UserEndpoint*. This naming convention (XYZEndpoint) is recommended for Serenity applications.

The namespace of this class is *MyProject.Administration.Endpoints*. This is another convention, as we usually put endpoints under the *MyProject.Module.Endpoints* namespace for consistency.

All service controllers should derive from the `ServiceEndpoint` class, which provides this MVC controller with special features that we'll see shortly.

### Route Attribute

```csharp
[Route("Services/Administration/User/[action]")]
```

The `Route` attribute above, used for ASP.NET attribute routing, configures the base address for our service endpoint. Actions will be accessible under `/Services/Administration/User`.

All Serenity service endpoints follow the `/Services/Module/Entity` addressing scheme by default. Though you can choose another scheme, this convention ensures consistency.

### ConnectionKey Attribute

```csharp
[ConnectionKey(typeof(MyRow))]
```

This attribute specifies the connection key in your application configuration file (e.g., `appsettings.json`) to be used when creating a connection.

Here, the connection key is indirectly specified through the `MyRow` (alias for `UserRow`) class:

```csharp
[ConnectionKey("Default"), Module("Administration"), TableName("Users")]
public sealed partial class UserRow
```

Thus, the connection key is determined from the row type's `ConnectionKey` attribute. This reuses information instead of explicitly specifying the `"Default"` string in endpoints and elsewhere.

Let's explore how this auto-created connection is used:

```csharp
public ListResponse<MyRow> List(IDbConnection connection, UserListRequest request,
    [FromServices] IUserListHandler handler)
```

Here, the action takes an `IDbConnection` argument. You can't send an `IDbConnection` to an MVC action from the client. So, who creates this connection?

As our controller derives from `ServiceEndpoint`, the base class is aware that the action requires a connection. It checks the `[ConnectionKey]` attribute atop the endpoint class to determine the connection key, creates a connection using `ISqlConnections.NewByKey()`, executes the action with this connection, and closes the connection after execution.

You could remove this connection parameter from the action and create it manually:

```csharp
public ListResponse<MyRow> List(UserListRequest request,
    [FromServices] IUserListHandler handler, [FromServices] ISqlConnections sqlConnections)
{
    using (var connection = sqlConnections.NewByKey("Default"))
    {
        return handler.List(connection, request);
    }
}
```

This mirrors what `ServiceEndpoint` does behind the scenes.

Why not use this feature when the platform handles this detail automatically? One reason might be when you need to open a custom connection not listed in the config file, or open a dynamic one based on conditions.

Another method takes an `IUnitOfWork` (transaction) instead of an `IDbConnection` parameter:

```csharp
public SaveResponse Create(IUnitOfWork uow, SaveRequest<MyRow> request, 
    [FromServices] IUserSaveHandler handler)
```

Here, the situation is similar. The `ServiceEndpoint` base class creates a connection and starts a transaction on it (`IUnitOfWork`). It calls our action method, and upon return, commits the transaction automatically. If it fails, the transaction will be rolled back.

Here's the manual version of the same thing:

```csharp
public SaveResponse Create(SaveRequest<MyRow> request, 
    [FromServices] IUserSaveHandler handler,
    [FromServices] ISqlConnections sqlConnections)
{
    using (var connection = sqlConnections.NewByKey("Default"))
    using (var uow = new UnitOfWork(connection))
    {
        var result = handler.Create(uow, request);
        uow.Commit();
        return result;
    }
}
```

Thus, `ServiceEndpoint` simplifies a process that would otherwise take 8 lines into 1 line of code.

### When To Use IUnitOfWork / IDbConnection

By convention, Serenity action methods that modify some state (Create, Update, etc.) should run inside a transaction, thus taking an `IUnitOfWork` parameter. On the other hand, methods that are read-only operations (List, Retrieve, etc.) should use an `IDbConnection`.

If your service method takes an `IUnitOfWork` parameter, it suggests that your method might modify some data.

### About [HttpPost] Attribute

You may have noticed that Create, Update, and Delete methods have this attribute while List, Retrieve, etc. do not.

This attribute restricts Create, Update, and Delete actions to HTTP POST only, disallowing them to be called via HTTP GET. This limitation is because these methods modify some state, such as inserting, updating, or deleting records from the database. They shouldn't be callable unintentionally, and their results shouldn't be cacheable.

> Additionally, there are security implications as actions with the GET method might be prone to certain attacks.

List and Retrieve methods do not modify anything, so they are allowed to be called with GET requests, such as typing in a browser address bar.

Even though List and Retrieve can be called via GET, Serenity always utilizes HTTP POST when invoking services using its methods (e.g., via the `serviceCall` method) and disables caching to prevent unexpected outcomes.

### ServiceAuthorize Attribute

Our controller class is adorned with the `ServiceAuthorize` attribute:

```csharp
ServiceAuthorize(typeof(MyRow))
```

This attribute resembles ASP.NET Core's [Authorize] attribute, but `Authorize` only verifies if the user is logged in and throws an exception otherwise.

When used with no parameters (e.g., `[ServiceAuthorize()]`), this attribute also checks that the user is logged in.

When provided with a permission key string, it verifies that the user is logged in and possesses that permission.

```csharp
ServiceAuthorize("SomePermission")
```

If the user is not granted "SomePermission", they will be prevented from executing any endpoint method.

In our example, we indirectly obtain the permission key from the `ReadPermission` attribute of the `UserRow` class.

There's also the `[PageAuthorize]` attribute that functions similarly. However, `[ServiceAuthorize]` is preferred with service endpoints because its error handling is more suitable for services.

While `[PageAuthorize]` redirects the user to the Login page if they lack permission, `ServiceAuthorize` returns a more suitable `NotAuthorized` type of service error.

It's also possible to use the [ServiceAuthorize] attribute on actions, instead of the controller:

```csharp
[ServiceAuthorize("SomePermissionThatIsRequiredForCreate")]
public SaveResponse Create(SaveRequest<MyRow> request,
```

In this case, the attribute on the action takes precedence over the one on the class.

The `AuthorizeCreate` attribute atop the `Create` method is a specialized subclass of the `ServiceAuthorize` attribute.

```csharp
[AuthorizeCreate(typeof(MyRow))]
```

It inspects one of the `[InsertPermission]`, `[ModifyPermission]`, and `[ReadPermission]` attributes on the row class (first one found) to determine the permission key to check. Similar attributes exist for other operations, such as `AuthorizeUpdate` and `AuthorizeDelete`, which check the `UpdatePermission` or `DeletePermission` attributes, respectively.

### About Request and Response Objects

Apart from the specially handled `IUnitOfWork` and `IDbConnection` parameters, all Serenity service actions take a single request parameter and return a single result.

```csharp
public SaveResponse Create(IUnitOfWork uow, SaveRequest<MyRow> request,
```

Let's start with the result. If you're familiar with ASP.NET MVC, you'd know that controllers can't return arbitrary objects. They must return objects that derive from `ActionResult` or implement `IActionResult`.

However, our `SaveResponse` derives from `ServiceResponse`, which is just a plain object:

```csharp
public class ServiceResponse
{
    public ServiceError Error { get; set; }
}

public class SaveResponse : ServiceResponse
{
    public object EntityId { get; set; }
    // ...
}
```

How is this possible? Once again, `ServiceEndpoint` handles this detail behind the scenes. It transforms our `SaveResponse` to a special action result that returns JSON data.

We don't have to worry about this detail as long as our response object derives from `ServiceResponse` and is JSON-serializable.
### About Request and Response Objects

Once again, our request object is simply an ordinary class that derives from a basic `ServiceRequest`:

```csharp
public class ServiceRequest
{
} 

public class SaveRequest<TEntity> : ServiceRequest, ISaveRequest
{
    public object EntityId { get; set; }
    public TEntity Entity { get; set; }
}

```

`ServiceEndpoint` takes the HTTP request content, usually in JSON format, and deserializes it into our *request* parameter using a special action filter (`[JsonRequest]` attribute).

If you want to define custom actions, your methods should also adhere to this philosophy, accepting just one request (deriving from `ServiceRequest`) and returning one response (deriving from `ServiceResponse`).

Let's define a service method that returns the count of all orders greater than a certain amount:

```csharp
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
        // ...
    }
}
```

Please adhere to this pattern and try not to add more parameters to action methods. Serenity follows the message-based pattern, with a single request object that can be extended later by adding more properties.

Avoid using RPC (Remote Procedure Call) style like this:

```csharp
public class OrderController : ServiceEndpoint
{
    public decimal MyOrderCount(IDbConnection connection, 
        decimal minAmount, decimal maxAmount, ....)
    {
        // ...
    }
}
```

Prefer message-based services like this:

```csharp
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

This approach avoids having to remember parameter orders, makes request objects extensible without breaking backward compatibility, and offers many more advantages that you may notice later.

If you don't follow this convention, Serenity won't be able to create client-side service call helpers like the following:

```typescript
export namespace UserService {
    export const baseUrl = 'Administration/User';
    export declare function Create(request: SaveRequest<UserRow>, 
        onSuccess?: (response: SaveResponse) => void, 
        opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;

    export declare function List(request: UserListRequest, 
        onSuccess?: (response: ListResponse<UserRow>) => void, 
        opt?: ServiceOptions<any>): PromiseLike<ListResponse<UserRow>>;
```

And when you try to call them by other means, the arguments won't be populated as you expect because service endpoints can only auto-serialize/deserialize single request/response classes that derive from `ServiceRequest`/`ServiceResponse` types. They won't be able to work with primitive values like strings, integers, etc.

### Why Endpoint Methods Are Almost Empty

We usually delegate the actual work to our handler layer:

```csharp
public ListResponse<MyRow> List(IDbConnection connection, ListRequest request,
    [FromServices] IUserListHandler handler)
{
    return handler.List(connection, request);
}
```

Here, `IUserListHandler` is a service dependency injected via ASP.NET's inversion-of-control mechanism (`[FromServices]` attribute). We prefer wrapping our business logic into request/operation handler classes.

Remember that `ServiceEndpoint` has a direct dependency on ASP.NET Core. This means that any code you write inside a service endpoint will have a dependency on ASP.NET Core controllers and thus the web environment.

You may not be able to reuse any code you wrote inside an action from a desktop application, or won't be able to isolate this code into a DLL that doesn't have a reference to web libraries. This is also important for testability concerns.

But if you don't have such a requirement, even though not recommended, you could remove handlers altogether and write all your code inside the endpoint.

Some people might argue that entities, repositories, business rules, endpoints, etc., should all be in their isolated assemblies. In theory, and for some scenarios, this might be valid, but some (or most) users don't need so much isolation and may fall into the YAGNI (You Aren't Gonna Need It) category.