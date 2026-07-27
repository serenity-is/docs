# ApplicationPartsTypeSource class
**namespace:** *[Serenity.Web](../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Net.Web](../README.md)*

Implementation for a type source that uses ApplicationPartManager to get assemblies. Note that it only includes assemblies that are marked with TypeSourceAssemblyAttribute which is automatically added to assemblies that reference Serenity.Net.Web NuGet package (or Serenity.Net.Web.targets).

```csharp
public class ApplicationPartsTypeSource : BaseAssemblyTypeSource
```

## Public Members

| name | description |
| --- | --- |
| [ApplicationPartsTypeSource](ApplicationPartsTypeSource/ApplicationPartsTypeSource.md)(…) | Implementation for a type source that uses ApplicationPartManager to get assemblies. Note that it only includes assemblies that are marked with TypeSourceAssemblyAttribute which is automatically added to assemblies that reference Serenity.Net.Web NuGet package (or Serenity.Net.Web.targets). |
| readonly [PartManager](ApplicationPartsTypeSource/PartManager.md) | Gets the application part manager |
| override [GetAssemblies](ApplicationPartsTypeSource/GetAssemblies.md)() |  |

## Protected Members

| name | description |
| --- | --- |
| virtual [GetApplicationPartAssemblies](ApplicationPartsTypeSource/GetApplicationPartAssemblies.md)() | Gets all the assemblies from application part manager. |
| virtual [GetImplicitAssemblies](ApplicationPartsTypeSource/GetImplicitAssemblies.md)() | Gets set of implicitly included assemblies, by default Serenity.Net.Core to Serenity.Net.Web |
| virtual [IsTypeSourceAssembly](ApplicationPartsTypeSource/IsTypeSourceAssembly.md)(…) | Returns true for assemblies that are marked with TypeSourceAssemblyAttribute |
| virtual [TopologicalSort](ApplicationPartsTypeSource/TopologicalSort.md)(…) | Sorts assemblies by dependency order |

## See Also

* class [BaseAssemblyTypeSource](../Serenity.Net.Core/../Serenity.Abstractions/BaseAssemblyTypeSource.md)
* **Source:** *[ApplicationPartsTypeSource.cs](https://github.com/serenity-is/Serenity/blob/master/src/Web/Mvc/ApplicationPartsTypeSource.cs)*