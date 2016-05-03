# Service Endpoints

In Serenity, Service Endpoints are a subclass of ASP.NET MVC controllers.

Here is an excerpt from Northwind OrderEndpoint:

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


### Controller Naming and Namespace

Our class has name *OrderController*, even though its file is named *OrderEndpoint.cs*. This is due to a ASP.NET MVC limitation (which i don't find so logical) that all controllers must end with *Controller* suffix. 

If you don't end your controller class name with this suffix, your actions will simply won't work. So be very careful with this.

> I also did this mistake several times and it cost me hours.

Namespace of this class (*Serene.Northwind.Endpoints*) is not important at all, though we usually put endpoints under *MyProject.Module.Endpoints* namespace for consistency.

Our OrderController derives from ServiceEndpoint (and should), which provides this MVC controller with not so usual features that we'll see shortly.


### Routing Attributes

```cs
[RoutePrefix("Services/Northwind/Order"), Route("{action}")]
```
Routing attributes above, which belongs to ASP.NET attribute routing, configures base address for our service endpoint. Our actions will be available under "mysite.com/Services/Northwind/Order".

> Please avoid classic ASP.NET MVC routing, where you configured all routes in ApplicationStart method with *routes.AddRoute* etc. It was really hard to manage.

All Serenity service endpoints uses */Services/Module/Entity* addressing scheme by default. Again even though you'd be able to use another address scheme, this is recommended for consistency and basic conventions.


### ConnectionKey Attribute

This attribute specificies which connection key in your application configuration file (e.g. web.config) should be used to create a connection when needed.

Let's see when and how this auto created connection is used:

```cs
public ListResponse<MyRow> List(IDbConnection connection, ListRequest request)
{
    return new MyRepository().List(connection, request);
}
```

Here we see that this action takes a IDbConnection parameter. You can't send a IDbConnection to an MVC action from client side. So who creates this connection?

Remember that our controller derives from ServiceEndpoint? So ServiceEndpoint understands that our action requires a connection. It checks [ConnectionKey] attribute on top of controller class to determine connection key, creates a connection using *SqlConnections.NewByKey()*, executes our action with this connection, and when action ends executing, closes the connection.

You'd be able to remove this connection parameter from the action and create it manually:

```cs
public ListResponse<MyRow> List(ListRequest request)
{
    using (var connection = SqlConnections.NewByKey("Northwind")) 
    {
        return new MyRepository().List(connection, request);
    }
}
```

Actually this is what ServiceEndpoint does behind the scenes.

Why not use this feature while platform handles this detail automatically? One reason would be when you need to open a custom connection that is not listed in the config file, or open a dynamic one depending on some conditions.

We have another method that takes IUnitOfWork (transaction), instead of IDbConnection parameter:

```cs
public SaveResponse Create(IUnitOfWork uow, SaveRequest<MyRow> request)
{
    return new MyRepository().Create(uow, request);
}
```

Here situation is similar. ServiceEndpoint again creates a connection, but this time starts a transaction on it (IUnitOfWork), calls our action method, and when it returns will commit transaction automatically. Again, if it fails, would rollback it.

Here is the manual version of the same thing:

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

So, ServiceEndpoint handles something that takes 8 lines in 1 line of code.


### When To Use IUnitOfWork / IDbConnection

By convention, Serenity action methods that modify some state (CREATE, UPDATE etc.) should run inside a transaction, thus take an IUnitOfWork parameter, and ones that are read only operations (LIST, RETRIEVE) should use IDbConnection.

If your service method takes a IUnitOfWork parameter, this is a signature that your method might modify some data.

### About [HttpPost] Attribute

You may have noticed that Create, Update, Delete etc methods has this attribute while List, Retrieve etc. not.

This attribute limits Create, Update, Delete actions to HTTP POST only. It doesn't allow them to be called by HTTP GET.

This is because, these methods are ones that modify some state, e.g. insert, update, delete some records from DB, so they shouldn't be allowed to be called unintentionally, and their results shouldn't be allowed to be cached.

> This also has some security implications. Actions with GET method might be subject to some attacks.

List, Retrieve doesn't modify anything, so they are allowed to be called with GET, e.g. typing in a browser address bar.

Even though, List, Retrieve can be called by GET, Serenity always calls services using HTTP POST when you use its methods, e.g. Q.CallService, and will turn of caching to avoid unexpected results.


### ServiceAuthorize Attribute

Our controller class has ServiceAuthorize attribute:

```
ServiceAuthorize(Northwind.PermissionKeys.General)
```

This attribute is similar to ASP.NET MVC [Authorize] attribute but it checks only that user is logged in, and throws an exception otherwise.

If used with no parameters, e.g. [ServiceAuthorize()] this attribute also checks that user is logged in.

When you pass it a permission key string, it will check that user is logged in and also has that permission.

```
ServiceAuthorize("SomePermission")
```

If user is not granted "SomePermission", this will prevent him from executing any endpoint method.

There is also [PageAuthorize] attribute that works similar, but you should prefer [ServiceAuthorize] with service endpoints, because its error handling is more suitable for services.

While [PageAuthorize] **redirects** user to the Login page, if user doesn't have the permission, ServiceAuthorize returns a more suitable **NotAuthorized service error**.

It's also possible to use [ServiceAuthorize] attribute on actions, instead of controller:

```cs
[ServiceAuthorize("SomePermissionThatIsRequiredForCreate")]
public SaveResponse Create(SaveRequest<MyRow> request)
```

