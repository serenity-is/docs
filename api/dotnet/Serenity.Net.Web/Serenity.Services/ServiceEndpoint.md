# ServiceEndpoint class
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Web](../README.md)*

Subclass of controller for service endpoints

```csharp
public abstract class ServiceEndpoint : Controller
```

## Public Members

| name | description |
| --- | --- |
| override [OnActionExecuted](ServiceEndpoint/OnActionExecuted.md)(…) |  |
| override [OnActionExecuting](ServiceEndpoint/OnActionExecuting.md)(…) |  |

## Protected Members

| name | description |
| --- | --- |
| [ServiceEndpoint](ServiceEndpoint/ServiceEndpoint.md)() | The default constructor. |
| [Cache](ServiceEndpoint/Cache.md) { get; } | Gets the cache from the request context |
| [Context](ServiceEndpoint/Context.md) { get; set; } | Gets the request context |
| [Localizer](ServiceEndpoint/Localizer.md) { get; } | Gets the localizer from the request context |
| [Permissions](ServiceEndpoint/Permissions.md) { get; } | Gets the permission service from the request context |
| override [Dispose](ServiceEndpoint/Dispose.md)(…) |  |

## See Also

* **Source:** *[ServiceEndpoint.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Web/Mvc/ServiceEndpoint.cs)*