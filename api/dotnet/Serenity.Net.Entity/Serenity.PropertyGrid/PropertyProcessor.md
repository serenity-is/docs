# PropertyProcessor class
**namespace:** *[Serenity.PropertyGrid](../README.md#serenity.propertygrid-namespace)*   **assembly**: *[Serenity.Net.Entity](../README.md)*

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

* interface [IPropertyProcessor](IPropertyProcessor.md)
* **Source:** *[PropertyProcessor.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Entity/PropertyGrid/PropertyProcessor.cs)*