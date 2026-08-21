# DynamicScriptServiceCollectionExtensions.AddScriptBundling method (1 of 2)
**namespace:** *[Serenity.Extensions.DependencyInjection](../../README.md#serenity.extensions.dependencyinjection-namespace)*   **assembly**: *[Serenity.Net.Web](../../README.md)*

Registers the default service types related to script bundling, including [`IScriptBundleManager`](../../Serenity.Web/IScriptBundleManager.md).

```csharp
public static IServiceCollection AddScriptBundling(this IServiceCollection collection)
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

---

# DynamicScriptServiceCollectionExtensions.AddScriptBundling method (2 of 2)
**namespace:** *[Serenity.Extensions.DependencyInjection](../../README.md#serenity.extensions.dependencyinjection-namespace)*   **assembly**: *[Serenity.Net.Web](../../README.md)*

Registers the default service types related to script bundling, including [`IScriptBundleManager`](../../Serenity.Web/IScriptBundleManager.md).

```csharp
public static void AddScriptBundling(this IServiceCollection collection, 
    Action<ScriptBundlingOptions> setupAction)
```

| parameter | description |
| --- | --- |
| collection | The service collection. |
| setupAction | The action to edit options. |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | *collection* or *setupAction* is `null`. |

## See Also

* class [ScriptBundlingOptions](../../Serenity.Web/ScriptBundlingOptions.md)
* class [DynamicScriptServiceCollectionExtensions](../DynamicScriptServiceCollectionExtensions.md)