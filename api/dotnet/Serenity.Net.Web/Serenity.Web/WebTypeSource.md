# WebTypeSource class
**namespace:** *[Serenity.Web](../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Net.Web](../README.md)*

Base type source for apps using Serenity.Web assembly and its reference chain

```csharp
public class WebTypeSource : BaseAssemblyTypeSource
```

## Public Members

| name | description |
| --- | --- |
| [WebTypeSource](WebTypeSource/WebTypeSource.md)(…) | Base type source for apps using Serenity.Web assembly and its reference chain |
| override [GetAssemblies](WebTypeSource/GetAssemblies.md)() |  |
| static readonly [SerenityNetCoreAssembly](WebTypeSource/SerenityNetCoreAssembly.md) | Reference to Serenity.Net.Core assembly |
| static readonly [SerenityNetServicesAssembly](WebTypeSource/SerenityNetServicesAssembly.md) | Reference to Serenity.Net.Services assembly |
| static readonly [SerenityNetWebAssembly](WebTypeSource/SerenityNetWebAssembly.md) | Reference to Serenity.Net.Web assembly |
| static readonly [SerenityNetWebAssemblyChain](WebTypeSource/SerenityNetWebAssemblyChain.md) | List of assemblies up to Serenity.Web |

## See Also

* class [BaseAssemblyTypeSource](../Serenity.Net.Core/../Serenity.Abstractions/BaseAssemblyTypeSource.md)
* **Source:** *[WebTypeSource.cs](https://github.com/serenity-is/Serenity/blob/master/src/Web/Mvc/WebTypeSource.cs)*