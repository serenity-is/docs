# DynamicScriptServiceCollectionExtensions.AddDynamicScriptManager method

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