# DynamicScriptServiceCollectionExtensions.UseTemplateScripts method (1 of 2)
**namespace:** *[Serenity.Extensions.DependencyInjection](../../README.md#serenity.extensions.dependencyinjection-namespace)*   **assembly**: *[Serenity.Net.Web](../../README.md)*

Registers template scripts

```csharp
public static IServiceProvider UseTemplateScripts(this IServiceProvider serviceProvider)
```

| parameter | description |
| --- | --- |
| serviceProvider | Service provider |

## See Also

* class [DynamicScriptServiceCollectionExtensions](../DynamicScriptServiceCollectionExtensions.md)

---

# DynamicScriptServiceCollectionExtensions.UseTemplateScripts method (2 of 2)
**namespace:** *[Serenity.Extensions.DependencyInjection](../../README.md#serenity.extensions.dependencyinjection-namespace)*   **assembly**: *[Serenity.Net.Web](../../README.md)*

Registers template scripts

```csharp
public static IServiceProvider UseTemplateScripts(this IServiceProvider serviceProvider, 
    params string[] templateRoots)
```

| parameter | description |
| --- | --- |
| serviceProvider | Service provider |
| templateRoots | Root paths for templates |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | Service provider or template roots is null |

## See Also

* class [DynamicScriptServiceCollectionExtensions](../DynamicScriptServiceCollectionExtensions.md)