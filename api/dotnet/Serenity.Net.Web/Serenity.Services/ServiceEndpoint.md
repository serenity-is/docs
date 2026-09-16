# ServiceEndpoint class
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Web](../README.md)*

Subclass of controller for service endpoints.

```csharp
public abstract class ServiceEndpoint : ControllerBase, IActionFilter, IAsyncActionFilter, 
    IAsyncDisposable, IDisposable
```

## Public Members

| name | description |
| --- | --- |
| [Dispose](ServiceEndpoint/Dispose.md)() |  |
| [DisposeAsync](ServiceEndpoint/DisposeAsync.md)() |  |
| virtual [OnActionExecuted](ServiceEndpoint/OnActionExecuted.md)(…) | Called after the action method is invoked. |
| virtual [OnActionExecuting](ServiceEndpoint/OnActionExecuting.md)(…) | Called before the action method is invoked. |
| virtual [OnActionExecutionAsync](ServiceEndpoint/OnActionExecutionAsync.md)(…) | Called before the action method is invoked. |

## Protected Members

| name | description |
| --- | --- |
| [ServiceEndpoint](ServiceEndpoint/ServiceEndpoint.md)() | The default constructor. |
| [Cache](ServiceEndpoint/Cache.md) { get; } | Gets the cache from the request context. |
| [Context](ServiceEndpoint/Context.md) { get; set; } | Gets the request context. |
| [HasRequestContext](ServiceEndpoint/HasRequestContext.md) { get; } | Gets whether a request context (e.g. Context property) is available. |
| [Localizer](ServiceEndpoint/Localizer.md) { get; } | Gets the localizer from the request context. |
| [Permissions](ServiceEndpoint/Permissions.md) { get; } | Gets the permission service from the request context. |
| virtual [Dispose](ServiceEndpoint/Dispose.md)(…) | Releases all resources currently used by this Controller instance. |
| virtual [DisposeAsync](ServiceEndpoint/DisposeAsync.md)(…) | Releases all resources currently used by this Controller instance. |
| virtual [OnActionExecutedAsync](ServiceEndpoint/OnActionExecutedAsync.md)(…) | Called after the action method is invoked asynchronously. |

## See Also

* **Source:** *[ServiceEndpoint.cs](https://github.com/serenity-is/Serenity/blob/eef6be1d7741640aed4ce405c3b44984620b84be/src/web/Mvc/ServiceEndpoint.cs)*