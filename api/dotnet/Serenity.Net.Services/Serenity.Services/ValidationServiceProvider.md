# ValidationServiceProvider class
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

The services of the ValidationContext a validation rule is checked in by a request handler: its own ones first, e.g. the connection in its transaction and the localizer of the request, then the ones of the request, when the request context gives them, see IServiceProviderAccessor.

```csharp
public class ValidationServiceProvider : IServiceProvider
```

| parameter | description |
| --- | --- |
| services | The services of the handler, by their types. |
| fallback | The services of the request, or null when there are none. |

## Public Members

| name | description |
| --- | --- |
| [ValidationServiceProvider](ValidationServiceProvider/ValidationServiceProvider.md)(…) | The services of the ValidationContext a validation rule is checked in by a request handler: its own ones first, e.g. the connection in its transaction and the localizer of the request, then the ones of the request, when the request context gives them, see IServiceProviderAccessor. |
| [GetService](ValidationServiceProvider/GetService.md)(…) |  |

## See Also

* **Source:** *[ValidationServiceProvider.cs](https://github.com/serenity-is/Serenity/blob/b1dab073ad31646cd015787ead45f6004717e72a/src/services/RequestHandlers/Save/ValidationServiceProvider.cs)*