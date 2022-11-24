# IPropertyProcessor interface
**namespace:** *[Serenity.PropertyGrid](../README.md#serenity.propertygrid-namespace)*   **assembly**: *[Serenity.Net.Entity](../README.md)*

Interface for property processors, which sets properties of a PropertyItem object by analysing a IPropertySource object.

```csharp
public interface IPropertyProcessor
```

## Members

| name | description |
| --- | --- |
| [BasedOnRow](IPropertyProcessor/BasedOnRow.md) { get; set; } | Gets or sets the based on row. |
| [Items](IPropertyProcessor/Items.md) { get; set; } | Gets or sets the items. |
| [Priority](IPropertyProcessor/Priority.md) { get; } | Gets the priority. The processors are called based on this priority. |
| [Type](IPropertyProcessor/Type.md) { get; set; } | Gets or sets the type property processor is working on. |
| [Initialize](IPropertyProcessor/Initialize.md)() | Initializes this instance. |
| [PostProcess](IPropertyProcessor/PostProcess.md)() | Called after process in a secondary pass. |
| [Process](IPropertyProcessor/Process.md)(…) | Sets properties of a PropertyItem by analysing a property source |

## See Also

* **Source:** *[IPropertyProcessor.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Entity/PropertyGrid/IPropertyProcessor.cs)*