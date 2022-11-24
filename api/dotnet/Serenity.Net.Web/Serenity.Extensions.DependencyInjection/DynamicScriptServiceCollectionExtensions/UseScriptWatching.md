# DynamicScriptServiceCollectionExtensions.UseScriptWatching method (1 of 2)
**namespace:** *[Serenity.Extensions.DependencyInjection](../../README.md#serenity.extensions.dependencyinjection-namespace)*   **assembly**: *[Serenity.Net.Web](../../README.md)*

Activates script file watching

```csharp
public static IServiceProvider UseScriptWatching(this IServiceProvider serviceProvider)
```

| parameter | description |
| --- | --- |
| serviceProvider | Service provider |

## See Also

* class [DynamicScriptServiceCollectionExtensions](../DynamicScriptServiceCollectionExtensions.md)

---

# DynamicScriptServiceCollectionExtensions.UseScriptWatching method (2 of 2)
**namespace:** *[Serenity.Extensions.DependencyInjection](../../README.md#serenity.extensions.dependencyinjection-namespace)*   **assembly**: *[Serenity.Net.Web](../../README.md)*

Activates script file watching

```csharp
public static IServiceProvider UseScriptWatching(this IServiceProvider serviceProvider, 
    params string[] scriptPaths)
```

| parameter | description |
| --- | --- |
| serviceProvider | Service provider |
| scriptPaths | List of script paths to watch |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | serviceProvider or scriptPaths is null |
| InvalidOperationException | Script bundle manager is not registered |

## See Also

* class [DynamicScriptServiceCollectionExtensions](../DynamicScriptServiceCollectionExtensions.md)