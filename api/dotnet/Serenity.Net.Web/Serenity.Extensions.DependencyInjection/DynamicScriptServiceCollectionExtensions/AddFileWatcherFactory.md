# DynamicScriptServiceCollectionExtensions.AddFileWatcherFactory method

Registers the default [`IFileWatcherFactory`](../../Serenity.Web/IFileWatcherFactory.md) implementation.

```csharp
public static IServiceCollection AddFileWatcherFactory(this IServiceCollection collection)
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