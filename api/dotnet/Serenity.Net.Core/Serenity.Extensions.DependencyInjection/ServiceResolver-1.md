# ServiceResolver&lt;TService&gt; class
**namespace:** *[Serenity.Extensions.DependencyInjection](../README.md#serenity.extensions.dependencyinjection-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

A generic version of IServiceProvider which resolves a service on demand.

```csharp
public class ServiceResolver<TService> : IServiceResolver<TService>
```

| parameter | description |
| --- | --- |
| TService |  |

## Public Members

| name | description |
| --- | --- |
| [ServiceResolver](ServiceResolver-1/ServiceResolver.md)(…) | Initializes a new instance. |
| [Resolve](ServiceResolver-1/Resolve.md)() | Resolves TService using the service provider. If the service was registered as transient, this method acts like a factory. |

## See Also

* interface [IServiceResolver&lt;TService&gt;](../Serenity/IServiceResolver-1.md)
* class [TService](../Serenity.Net.Core/ServiceResolver-1.TService.md)
* **Source:** *[ServiceResolver.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Core/Helpers/ServiceResolver.cs)*