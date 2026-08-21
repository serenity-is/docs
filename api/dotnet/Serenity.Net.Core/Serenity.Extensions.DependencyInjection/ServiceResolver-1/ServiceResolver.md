# ServiceResolver&lt;TService&gt; constructor
**namespace:** *[Serenity.Extensions.DependencyInjection](../../README.md#serenity.extensions.dependencyinjection-namespace)*   **assembly**: *[Serenity.Net.Core](../../README.md)*

A generic version of IServiceProvider which resolves a service on demand.

```csharp
public ServiceResolver(IServiceProvider serviceProvider)
```

| parameter | description |
| --- | --- |
| TService | The type of the service to resolve. |
| serviceProvider | The service provider. |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | Throws when the service provider is null. |

## Remarks

Initializes a new instance.

## See Also

* class [ServiceResolver&lt;TService&gt;](../ServiceResolver-1.md)