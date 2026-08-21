# ApplicationPartsServiceCollectionExtensions class
**namespace:** *[Serenity.Extensions.DependencyInjection](../README.md#serenity.extensions.dependencyinjection-namespace)*   **assembly**: *[Serenity.Net.Web](../README.md)*

DI extension methods related to application parts and type source.

```csharp
public static class ApplicationPartsServiceCollectionExtensions
```

## Public Members

| name | description |
| --- | --- |
| static [AddApplicationPartsFeatureToggles](ApplicationPartsServiceCollectionExtensions/AddApplicationPartsFeatureToggles.md)(…) | Adds the IFeatureToggles service to the registry, scanning for FeatureKeySetAttribute in application parts and disabling by default features that have a `[DefaultValue(false)]` attribute. Note that this also calls `AddMvcCore()` to get the part manager if it is not provided and not found in the collection. |
| static [AddApplicationPartsTypeSource](ApplicationPartsServiceCollectionExtensions/AddApplicationPartsTypeSource.md)(…) | Adds an application part type source to the service collection. Note that this also calls `AddMvcCore()` to get the part manager if it is not provided and not found in the collection. |

## See Also

* **Source:** *[ApplicationPartsServiceCollectionExtensions.cs](https://github.com/serenity-is/Serenity/blob/master/src/Web/Mvc/ApplicationPartsServiceCollectionExtensions.cs)*