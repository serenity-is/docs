# DateEditorAttribute class
**namespace:** *[Serenity.ComponentModel](../README.md#serenity.componentmodel-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Indicates that the target property should use a "Date" editor.

```csharp
[AttributeUsage(AttributeTargets.All)]
public class DateEditorAttribute : CustomEditorAttribute
```

## Public Members

| name | description |
| --- | --- |
| [DateEditorAttribute](DateEditorAttribute/DateEditorAttribute.md)() | Initializes a new instance of the [`DateEditorAttribute`](DateEditorAttribute.md) class. |
| [MaxValue](DateEditorAttribute/MaxValue.md) { get; set; } | Gets or sets the maximum value. |
| [MinValue](DateEditorAttribute/MinValue.md) { get; set; } | Gets or sets the minimum value. |
| [SqlMinMax](DateEditorAttribute/SqlMinMax.md) { get; set; } | Gets or sets a value indicating whether SQL server min max dates should be used. |
| const [Key](DateEditorAttribute/Key.md) | Editor type key |

## See Also

* class [CustomEditorAttribute](CustomEditorAttribute.md)
* **Source:** *[DateEditorAttribute.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Core/ComponentModel/PropertyGrid/EditorTypes/DateEditorAttribute.cs)*