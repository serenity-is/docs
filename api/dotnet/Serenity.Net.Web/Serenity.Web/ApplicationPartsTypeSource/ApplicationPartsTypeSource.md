# ApplicationPartsTypeSource constructor
**namespace:** *[Serenity.Web](../../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Net.Web](../../README.md)*

Implementation for a type source that uses ApplicationPartManager to get assemblies. Note that it only includes assemblies that are marked with TypeSourceAssemblyAttribute which is automatically added to assemblies that reference Serenity.Net.Web NuGet package (or Serenity.Net.Web.targets).

```csharp
public ApplicationPartsTypeSource(ApplicationPartManager partManager, bool topologicalSort = true, 
    IFeatureToggles featureToggles = null)
```

## See Also

* interface [IFeatureToggles](../Serenity.Net.Core/../../Serenity.Abstractions/IFeatureToggles.md)
* class [ApplicationPartsTypeSource](../ApplicationPartsTypeSource.md)