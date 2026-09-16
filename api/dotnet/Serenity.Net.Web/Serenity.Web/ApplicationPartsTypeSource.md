# ApplicationPartsTypeSource class
**namespace:** *[Serenity.Web](../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Net.Web](../README.md)*

Implementation of a type source that uses ApplicationPartManager to get assemblies. Note that it only includes assemblies that are marked with TypeSourceAssemblyAttribute, which is automatically added to assemblies that reference the Serenity.Net.Web NuGet package (or Serenity.Net.Web.targets).

```csharp
public class ApplicationPartsTypeSource : BaseAssemblyTypeSource
```

## Public Members

| name | description |
| --- | --- |
| [ApplicationPartsTypeSource](ApplicationPartsTypeSource/ApplicationPartsTypeSource.md)(…) | Implementation of a type source that uses ApplicationPartManager to get assemblies. Note that it only includes assemblies that are marked with TypeSourceAssemblyAttribute, which is automatically added to assemblies that reference the Serenity.Net.Web NuGet package (or Serenity.Net.Web.targets). |
| readonly [PartManager](ApplicationPartsTypeSource/PartManager.md) | Gets the application part manager. |
| override [GetAssemblies](ApplicationPartsTypeSource/GetAssemblies.md)() |  |

## Protected Members

| name | description |
| --- | --- |
| virtual [EnsureApplicationParts](ApplicationPartsTypeSource/EnsureApplicationParts.md)() | Tries to recover application parts when the generated application parts assembly info (e.g. `*.MvcApplicationPartsAssemblyInfo.cs`) was not included in the build. In that case the ApplicationPartManager only contains the entry assembly, which makes pages and navigation items from referenced assemblies disappear. This reads the application deps file, finds the assemblies that reference MVC and adds them to the part manager, just like the Razor SDK would have done at build time. It is only attempted once, and only when the entry assembly has no ApplicationPartAttribute at all and this assembly (Serenity.Net.Web) is missing from the part manager. Concurrent callers block until the recovery completes. |
| virtual [GetApplicationPartAssemblies](ApplicationPartsTypeSource/GetApplicationPartAssemblies.md)() | Gets all the assemblies from the application part manager. |
| virtual [GetImplicitAssemblies](ApplicationPartsTypeSource/GetImplicitAssemblies.md)() | Gets the set of implicitly included assemblies, by default from Serenity.Net.Core to Serenity.Net.Web. |
| virtual [IsTypeSourceAssembly](ApplicationPartsTypeSource/IsTypeSourceAssembly.md)(…) | Returns `true` for assemblies that are marked with TypeSourceAssemblyAttribute. |
| virtual [TopologicalSort](ApplicationPartsTypeSource/TopologicalSort.md)(…) | Sorts assemblies by dependency order. |

## See Also

* class [BaseAssemblyTypeSource](../../Serenity.Net.Core/Serenity.Abstractions/BaseAssemblyTypeSource.md)
* **Source:** *[ApplicationPartsTypeSource.cs](https://github.com/serenity-is/Serenity/blob/6246a6a0dcfa77021b805dede26464e4de2cb2f6/src/web/Mvc/ApplicationPartsTypeSource.cs)*