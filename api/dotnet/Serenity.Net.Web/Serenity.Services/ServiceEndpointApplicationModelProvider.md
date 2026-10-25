# ServiceEndpointApplicationModelProvider class
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Web](../README.md)*

Applies action model conventions for [`ServiceEndpoint`](./ServiceEndpoint.md) controllers.

```csharp
public class ServiceEndpointApplicationModelProvider : IApplicationModelProvider
```

## Public Members

| name | description |
| --- | --- |
| [ServiceEndpointApplicationModelProvider](ServiceEndpointApplicationModelProvider/ServiceEndpointApplicationModelProvider.md)() | The default constructor. |
| [Order](ServiceEndpointApplicationModelProvider/Order.md) { get; } | [ApiController] attribute model provider uses `-1000 + 100` - this needs to be applied first so that we get attribute routing. AuthorizationApplicationModelProvider uses +10 - so we're trying to split the difference here. |
| [OnProvidersExecuted](ServiceEndpointApplicationModelProvider/OnProvidersExecuted.md)(…) |  |
| [OnProvidersExecuting](ServiceEndpointApplicationModelProvider/OnProvidersExecuting.md)(…) |  |

## See Also

* **Source:** *[ServiceEndpointApplicationModelProvider.cs](https://github.com/serenity-is/Serenity/blob/b25593854f2e2d2560030f357d1bb7a1cbd85e65/src/web/Mvc/ServiceEndpoints/ServiceEndpointApplicationModelProvider.cs)*