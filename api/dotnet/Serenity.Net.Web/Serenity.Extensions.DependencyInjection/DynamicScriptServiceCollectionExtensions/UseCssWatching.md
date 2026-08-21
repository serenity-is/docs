# DynamicScriptServiceCollectionExtensions.UseCssWatching method (1 of 2)
**namespace:** *[Serenity.Extensions.DependencyInjection](../../README.md#serenity.extensions.dependencyinjection-namespace)*   **assembly**: *[Serenity.Net.Web](../../README.md)*

Activates CSS file watching.

```csharp
public static IServiceProvider UseCssWatching(this IServiceProvider serviceProvider)
```

| parameter | description |
| --- | --- |
| serviceProvider | The service provider. |

## See Also

* class [DynamicScriptServiceCollectionExtensions](../DynamicScriptServiceCollectionExtensions.md)

---

# DynamicScriptServiceCollectionExtensions.UseCssWatching method (2 of 2)
**namespace:** *[Serenity.Extensions.DependencyInjection](../../README.md#serenity.extensions.dependencyinjection-namespace)*   **assembly**: *[Serenity.Net.Web](../../README.md)*

Activates CSS file watching.

```csharp
public static IServiceProvider UseCssWatching(this IServiceProvider serviceProvider, 
    params string[] cssPaths)
```

| parameter | description |
| --- | --- |
| serviceProvider | The service provider. |
| cssPaths | The CSS paths to watch. |

## Return Value

The same service provider so that calls can be chained.

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | *serviceProvider* or *cssPaths* is `null`. |
| InvalidOperationException | No CSS bundle manager or content hash cache is registered. |

## See Also

* class [DynamicScriptServiceCollectionExtensions](../DynamicScriptServiceCollectionExtensions.md)