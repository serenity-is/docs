# IServiceResolver&lt;TService&gt; interface
**namespace:** *[Serenity](../README.md#serenity-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

A generic version of IServiceProvider which resolves a service on demand.

```csharp
public interface IServiceResolver<TService>
```

| parameter | description |
| --- | --- |
| TService |  |

## Members

| name | description |
| --- | --- |
| [Resolve](IServiceResolver-1/Resolve.md)() | Resolves TService using the service provider. If the service was registered as transient, this method acts like a factory. |

## See Also

* **Source:** *[IServiceResolver.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Core/Helpers/IServiceResolver.cs)*