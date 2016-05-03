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

Our class has name *OrderController*, even though its file is named *OrderEndpoint.cs*. This is due to a ASP.NET MVC limitation (which i don't find so logical) that all controllers must end with *Controller* suffix. 

If you don't end your controller class name with this suffix, your actions will simply won't work. So be very careful with this.

Namespace of this class (*Serene.Northwind.Endpoints*) is not important at all, though we usually put endpoints under *MyProject.Module.Endpoints* namespace for consistency.





