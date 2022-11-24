# DynamicScriptServiceCollectionExtensions.UseCssWatching method (1 of 2)
**namespace:** *[Serenity.Extensions.DependencyInjection](../../README.md#serenity.extensions.dependencyinjection-namespace)*   **assembly**: *[Serenity.Net.Web](../../README.md)*

Actives CSS file watching

```csharp
public static IServiceProvider UseCssWatching(this IServiceProvider serviceProvider)
```

| parameter | description |
| --- | --- |
| serviceProvider | Service provider |

## See Also

* class [DynamicScriptServiceCollectionExtensions](../DynamicScriptServiceCollectionExtensions.md)

---

# DynamicScriptServiceCollectionExtensions.UseCssWatching method (2 of 2)
**namespace:** *[Serenity.Extensions.DependencyInjection](../../README.md#serenity.extensions.dependencyinjection-namespace)*   **assembly**: *[Serenity.Net.Web](../../README.md)*

Activates CSS file watching

```csharp
public static IServiceProvider UseCssWatching(this IServiceProvider serviceProvider, 
    params string[] cssPaths)
```

| parameter | description |
| --- | --- |
| serviceProvider |  |
| cssPaths | CSS paths |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | serviceProvider is null |
| InvalidOperationException | CSS bundle manager is not registered |

## See Also

* class [DynamicScriptServiceCollectionExtensions](../DynamicScriptServiceCollectionExtensions.md)