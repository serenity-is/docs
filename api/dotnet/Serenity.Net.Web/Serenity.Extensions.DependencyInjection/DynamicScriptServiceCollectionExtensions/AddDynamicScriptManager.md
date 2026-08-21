# DynamicScriptServiceCollectionExtensions.AddDynamicScriptManager method
**namespace:** *[Serenity.Extensions.DependencyInjection](../../README.md#serenity.extensions.dependencyinjection-namespace)*   **assembly**: *[Serenity.Net.Web](../../README.md)*

Registers the default [`IDynamicScriptManager`](../../Serenity.Web/IDynamicScriptManager.md) implementation.

```csharp
public static IServiceCollection AddDynamicScriptManager(this IServiceCollection collection)
```

| parameter | description |
| --- | --- |
| collection | The service collection. |

## Return Value

The same service collection so that calls can be chained.

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | *collection* is `null`. |

## See Also

* class [DynamicScriptServiceCollectionExtensions](../DynamicScriptServiceCollectionExtensions.md)