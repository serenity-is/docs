# IServiceProviderAccessor interface
**namespace:** *[Serenity](../README.md#serenity-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Provides access to the service provider that should be used to resolve or activate services on demand, such as request handlers and behaviors.

```csharp
public interface IServiceProviderAccessor
```

## Members

| name | description |
| --- | --- |
| [ServiceProvider](IServiceProviderAccessor/ServiceProvider.md) { get; } | Gets the service provider to use. |

## Remarks

In web applications the returned provider is the current request's scoped provider when available, falling back to the root provider otherwise. Resolving through this abstraction instead of capturing an IServiceProvider in a singleton avoids the captive dependency problem for services that may be registered as scoped.

## See Also

* **Source:** *[IServiceProviderAccessor.cs](https://github.com/serenity-is/Serenity/blob/df6fb676c90d207452f30ac96d17cc9ba967a264/src/core/Helpers/IServiceProviderAccessor.cs)*