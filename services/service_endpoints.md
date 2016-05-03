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

> I also did this mistake several times and lost hours.

Namespace of this class (*Serene.Northwind.Endpoints*) is not important at all, though we usually put endpoints under *MyProject.Module.Endpoints* namespace for consistency.

```cs
[RoutePrefix("Services/Northwind/Order"), Route("{action}")]
```
Routing attributes above, which belongs to ASP.NET attribute routing, configures base address for our service endpoint. Our actions will be available under "mysite.com/Services/Northwind/Order".

> Please avoid classic ASP.NET MVC routing, where you configured all routes in ApplicationStart method with *routes.AddRoute* etc. It was really hard to manage.

All Serenity service endpoints uses */Services/Module/Entity* addressing scheme by default. Again even though you'd be able to use another address scheme, this is recommended for consistency and basic conventions.



