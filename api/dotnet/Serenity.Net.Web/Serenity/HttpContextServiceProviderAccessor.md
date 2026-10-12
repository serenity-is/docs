# HttpContextServiceProviderAccessor class
**namespace:** *[Serenity](../README.md#serenity-namespace)*   **assembly**: *[Serenity.Net.Web](../README.md)*

An IServiceProviderAccessor that uses the current HTTP request's scoped service provider when available, falling back to the root provider otherwise.

```csharp
public class HttpContextServiceProviderAccessor : IServiceProviderAccessor
```

| parameter | description |
| --- | --- |
| serviceProvider | Root service provider used when there is no active HTTP request. |
| httpContextAccessor | HTTP context accessor. |

## Public Members

| name | description |
| --- | --- |
| [HttpContextServiceProviderAccessor](HttpContextServiceProviderAccessor/HttpContextServiceProviderAccessor.md)(…) | An IServiceProviderAccessor that uses the current HTTP request's scoped service provider when available, falling back to the root provider otherwise. |
| [ServiceProvider](HttpContextServiceProviderAccessor/ServiceProvider.md) { get; } |  |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | *serviceProvider* is `null`. |

## Remarks

Initializes a new instance of the class.

## See Also

* interface [IServiceProviderAccessor](../../Serenity.Net.Core/Serenity/IServiceProviderAccessor.md)
* **Source:** *[HttpContextServiceProviderAccessor.cs](https://github.com/serenity-is/Serenity/blob/df6fb676c90d207452f30ac96d17cc9ba967a264/src/web/Common/HttpContextServiceProviderAccessor.cs)*