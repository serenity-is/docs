# BaseAssemblyTypeSource class
**namespace:** *[Serenity.Abstractions](../README.md#serenity.abstractions-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Base type source implementation that accepts a list of assemblies

```csharp
public abstract class BaseAssemblyTypeSource : IGetAssemblies, ITypeSource
```

| parameter | description |
| --- | --- |
| featureToggles | Feature toggles service used to filter types |

## Public Members

| name | description |
| --- | --- |
| abstract [GetAssemblies](BaseAssemblyTypeSource/GetAssemblies.md)() |  |
| virtual [GetAssemblyAttributes](BaseAssemblyTypeSource/GetAssemblyAttributes.md)(…) | Gets all attributes for assemblies with given type |
| virtual [GetTypes](BaseAssemblyTypeSource/GetTypes.md)() | Gets all types |
| virtual [GetTypesWithAttribute](BaseAssemblyTypeSource/GetTypesWithAttribute.md)(…) | Gets all types that has an attribute |
| virtual [GetTypesWithInterface](BaseAssemblyTypeSource/GetTypesWithInterface.md)(…) | Gets all types that implement an interface |

## Protected Members

| name | description |
| --- | --- |
| [BaseAssemblyTypeSource](BaseAssemblyTypeSource/BaseAssemblyTypeSource.md)(…) | Base type source implementation that accepts a list of assemblies |
| virtual [Include](BaseAssemblyTypeSource/Include.md)(…) | Used to filter assemblies based on feature toggles (2 methods) |

## Remarks

Creates a new instance

## See Also

* interface [IGetAssemblies](IGetAssemblies.md)
* interface [ITypeSource](ITypeSource.md)
* **Source:** *[BaseAssemblyTypeSource.cs](https://github.com/serenity-is/Serenity/blob/master/src/Core/ComponentModel/Extensibility/BaseAssemblyTypeSource.cs)*