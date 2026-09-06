# ExtensionsTypeSource class
**namespace:** *[Serenity.Extensions](../README.md#serenity.extensions-namespace)*   **assembly**: *[Serenity.Extensions](../README.md)*

Base type source for apps using Serenity.Extensions assembly and its reference chain

```csharp
public class ExtensionsTypeSource : WebTypeSource
```

| parameter | description |
| --- | --- |
| assemblies | Additional assemblies to include |

## Public Members

| name | description |
| --- | --- |
| [ExtensionsTypeSource](ExtensionsTypeSource/ExtensionsTypeSource.md)(…) | Base type source for apps using Serenity.Extensions assembly and its reference chain |
| override [GetAssemblies](ExtensionsTypeSource/GetAssemblies.md)() | Gets the assemblies in the Serenity.Extensions reference chain, plus any additional assemblies. |
| static readonly [SerenityExtensionsAssembly](ExtensionsTypeSource/SerenityExtensionsAssembly.md) | Reference to Serenity.Extensions assembly |
| static readonly [SerenityExtensionsAssemblyChain](ExtensionsTypeSource/SerenityExtensionsAssemblyChain.md) | List of assemblies up to Serenity.Extensions |

## See Also

* class [WebTypeSource](../../Serenity.Net.Web/Serenity.Web/WebTypeSource.md)
* **Source:** *[ExtensionsTypeSource.cs](https://github.com/serenity-is/Serenity/blob/47a8f36cd87e4c2377c35f4a9f9c1c4ba0155f61/common-features/src/extensions/Modules/Options/ExtensionsTypeSource.cs)*