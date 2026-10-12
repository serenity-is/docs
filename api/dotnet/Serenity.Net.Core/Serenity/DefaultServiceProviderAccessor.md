# DefaultServiceProviderAccessor class
**namespace:** *[Serenity](../README.md#serenity-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Default [`IServiceProviderAccessor`](./IServiceProviderAccessor.md) that always returns the same service provider.

```csharp
public class DefaultServiceProviderAccessor : IServiceProviderAccessor
```

| parameter | description |
| --- | --- |
| serviceProvider | The service provider to return. |

## Public Members

| name | description |
| --- | --- |
| [DefaultServiceProviderAccessor](DefaultServiceProviderAccessor/DefaultServiceProviderAccessor.md)(…) | Default [`IServiceProviderAccessor`](./IServiceProviderAccessor.md) that always returns the same service provider. |
| [ServiceProvider](DefaultServiceProviderAccessor/ServiceProvider.md) { get; } |  |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | *serviceProvider* is `null`. |

## Remarks

Initializes a new instance of the class.

## See Also

* interface [IServiceProviderAccessor](./IServiceProviderAccessor.md)
* **Source:** *[DefaultServiceProviderAccessor.cs](https://github.com/serenity-is/Serenity/blob/df6fb676c90d207452f30ac96d17cc9ba967a264/src/core/Helpers/DefaultServiceProviderAccessor.cs)*