# ModuleAttribute class
**namespace:** *[Serenity.ComponentModel](../README.md#serenity.componentmodel-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Sets the module name for the row. The module name is usually the folder name under the ~/Modules folder that the entity resides in.

```csharp
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Interface)]
public class ModuleAttribute : Attribute
```

| parameter | description |
| --- | --- |
| module | The module. |

## Public Members

| name | description |
| --- | --- |
| [ModuleAttribute](ModuleAttribute/ModuleAttribute.md)(…) | Sets the module name for the row. The module name is usually the folder name under the ~/Modules folder that the entity resides in. |
| [Value](ModuleAttribute/Value.md) { get; } | Gets the module. |

## Remarks

Initializes a new instance of the [`ModuleAttribute`](./ModuleAttribute.md) class.

## See Also

* **Source:** *[ModuleAttribute.cs](https://github.com/serenity-is/Serenity/blob/ab38d62505c08ddc4bb238600a765939de111cea/src/core/ComponentModel/Common/ModuleAttribute.cs)*