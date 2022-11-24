# DynamicScriptServiceCollectionExtensions.AddCssBundling method (1 of 2)
**namespace:** *[Serenity.Extensions.DependencyInjection](../../README.md#serenity.extensions.dependencyinjection-namespace)*   **assembly**: *[Serenity.Net.Web](../../README.md)*

Registers the default service types related to CSS bundling, including [`ICssBundleManager`](../../Serenity.Web/ICssBundleManager.md).

```csharp
public static void AddCssBundling(this IServiceCollection collection)
```

| parameter | description |
| --- | --- |
| collection | Service collection |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | Collection is null |

## See Also

* class [DynamicScriptServiceCollectionExtensions](../DynamicScriptServiceCollectionExtensions.md)

---

# DynamicScriptServiceCollectionExtensions.AddCssBundling method (2 of 2)
**namespace:** *[Serenity.Extensions.DependencyInjection](../../README.md#serenity.extensions.dependencyinjection-namespace)*   **assembly**: *[Serenity.Net.Web](../../README.md)*

Registers the default service types related to CSS bundling, including [`ICssBundleManager`](../../Serenity.Web/ICssBundleManager.md).

```csharp
public static void AddCssBundling(this IServiceCollection collection, 
    Action<CssBundlingOptions> setupAction)
```

| parameter | description |
| --- | --- |
| collection | Service collection |
| setupAction | Action to edit options |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | Collection is null |

## See Also

* class [CssBundlingOptions](../../Serenity.Web/CssBundlingOptions.md)
* class [DynamicScriptServiceCollectionExtensions](../DynamicScriptServiceCollectionExtensions.md)