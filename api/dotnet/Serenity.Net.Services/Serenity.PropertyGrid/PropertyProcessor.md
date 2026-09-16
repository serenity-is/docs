# PropertyProcessor class
**namespace:** *[Serenity.PropertyGrid](../README.md#serenity.propertygrid-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Base class for property processors, which sets properties of a PropertyItem object by analysing a IPropertySource object.

```csharp
public abstract class PropertyProcessor : IPropertyProcessor
```

## Public Members

| name | description |
| --- | --- |
| [BasedOnRow](PropertyProcessor/BasedOnRow.md) { get; set; } |  |
| [Items](PropertyProcessor/Items.md) { get; set; } |  |
| virtual [Priority](PropertyProcessor/Priority.md) { get; } |  |
| [Type](PropertyProcessor/Type.md) { get; set; } |  |
| virtual [Initialize](PropertyProcessor/Initialize.md)() |  |
| virtual [PostProcess](PropertyProcessor/PostProcess.md)() |  |
| virtual [Process](PropertyProcessor/Process.md)(…) |  |

## Protected Members

| name | description |
| --- | --- |
| [PropertyProcessor](PropertyProcessor/PropertyProcessor.md)() | The default constructor. |

## See Also

* interface [IPropertyProcessor](./IPropertyProcessor.md)
* **Source:** *[PropertyProcessor.cs](https://github.com/serenity-is/Serenity/blob/7d4534fc93adbd2968e8fbf317070a0cb6f67b1e/src/services/Entity/PropertyGrid/PropertyProcessor.cs)*