# ITypeSource interface
**namespace:** *[Serenity.Abstractions](../README.md#serenity.abstractions-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Abstraction for type source which is used as an extensibility point for Serenity applications

```csharp
public interface ITypeSource
```

## Members

| name | description |
| --- | --- |
| [GetAssemblyAttributes](ITypeSource/GetAssemblyAttributes.md)(…) | Gets all attributes for assemblies with given type |
| [GetTypes](ITypeSource/GetTypes.md)() | Gets all types |
| [GetTypesWithAttribute](ITypeSource/GetTypesWithAttribute.md)(…) | Gets all types that has an attribute |
| [GetTypesWithInterface](ITypeSource/GetTypesWithInterface.md)(…) | Gets all types that implement an interface |

## See Also

* **Source:** *[ITypeSource.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Core/ComponentModel/Extensibility/ITypeSource.cs)*