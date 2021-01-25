# PropertyProcessor class
**namespace:** *[Serenity.PropertyGrid](../README.md#serenity.propertygrid-namespace)*   **assembly**: *[Serenity.Net.Entity](../README.md)*

Base class for property processors, which sets properties of a PropertyItem object by analysing a IPropertySource object.

```csharp
public abstract class PropertyProcessor : IPropertyProcessor
```

## Public Members

| name | description |
| --- | --- |
| [BasedOnRow](PropertyProcessor/BasedOnRow.md) { get; set; } | Gets or sets the based on row. |
| [Items](PropertyProcessor/Items.md) { get; set; } | Gets or sets the items. |
| virtual [Priority](PropertyProcessor/Priority.md) { get; } | Gets the priority. |
| [Type](PropertyProcessor/Type.md) { get; set; } | Gets or sets the type. |
| virtual [Initialize](PropertyProcessor/Initialize.md)() | Initializes this instance. |
| virtual [PostProcess](PropertyProcessor/PostProcess.md)() | Posts the process. |
| virtual [Process](PropertyProcessor/Process.md)(…) | Processes the specified source. |

## Protected Members

| name | description |
| --- | --- |
| [PropertyProcessor](PropertyProcessor/PropertyProcessor.md)() | The default constructor. |

## See Also

* interface [IPropertyProcessor](IPropertyProcessor.md)
* **Source:** *[PropertyProcessor.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Entity/PropertyGrid/PropertyProcessor.cs)*