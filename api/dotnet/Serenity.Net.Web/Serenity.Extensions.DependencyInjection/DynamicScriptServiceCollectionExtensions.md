# DynamicScriptServiceCollectionExtensions class
**namespace:** *[Serenity.Extensions.DependencyInjection](../README.md#serenity.extensions.dependencyinjection-namespace)*   **assembly**: *[Serenity.Net.Web](../README.md)*

Contains DI extension methods related to dynamic script services

```csharp
public static class DynamicScriptServiceCollectionExtensions
```

## Public Members

| name | description |
| --- | --- |
| static [AddContentHashCache](DynamicScriptServiceCollectionExtensions/AddContentHashCache.md)(…) | Registers the default [`IContentHashCache`](../Serenity.Web/IContentHashCache.md) implementation. |
| static [AddCssBundling](DynamicScriptServiceCollectionExtensions/AddCssBundling.md)(…) | Registers the default service types related to CSS bundling, including [`ICssBundleManager`](../Serenity.Web/ICssBundleManager.md). (2 methods) |
| static [AddDynamicScriptManager](DynamicScriptServiceCollectionExtensions/AddDynamicScriptManager.md)(…) | Registers he default [`IDynamicScriptManager`](../Serenity.Web/IDynamicScriptManager.md) implementation. |
| static [AddDynamicScripts](DynamicScriptServiceCollectionExtensions/AddDynamicScripts.md)(…) | Registers the default [`IDynamicScriptManager`](../Serenity.Web/IDynamicScriptManager.md) implementation in addition to the IPropertyItemProvider implementation. |
| static [AddFileWatcherFactory](DynamicScriptServiceCollectionExtensions/AddFileWatcherFactory.md)(…) | Registers the default [`IFileWatcherFactory`](../Serenity.Web/IFileWatcherFactory.md) implementation. |
| static [AddScriptBundling](DynamicScriptServiceCollectionExtensions/AddScriptBundling.md)(…) | Registers the default service types related to Script bundling, including [`IScriptBundleManager`](../Serenity.Web/IScriptBundleManager.md). (2 methods) |
| static [UseCssWatching](DynamicScriptServiceCollectionExtensions/UseCssWatching.md)(…) | Actives CSS file watching (2 methods) |
| static [UseDynamicScriptMiddleware](DynamicScriptServiceCollectionExtensions/UseDynamicScriptMiddleware.md)(…) | Adds [`DynamicScriptMiddleware`](../Serenity.Web.Middleware/DynamicScriptMiddleware.md) to the application pipeline |
| static [UseDynamicScripts](DynamicScriptServiceCollectionExtensions/UseDynamicScripts.md)(…) | Adds dynamic script related services to the application including dynamic script types, css watching, script watching, template scripts, and dynamic script middleware |
| static [UseDynamicScriptTypes](DynamicScriptServiceCollectionExtensions/UseDynamicScriptTypes.md)(…) | Executes registration of dynamic script types including data scripts, lookup scripts, distinct values, columns and forms. |
| static [UseScriptWatching](DynamicScriptServiceCollectionExtensions/UseScriptWatching.md)(…) | Activates script file watching (2 methods) |
| static [UseTemplateScripts](DynamicScriptServiceCollectionExtensions/UseTemplateScripts.md)(…) | Registers template scripts (2 methods) |

## See Also

* **Source:** *[DynamicScriptServiceCollectionExtensions.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Web/DynamicScript/DynamicScript/DynamicScriptServiceCollectionExtensions.cs)*