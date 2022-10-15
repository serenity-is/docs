# DateYearEditorAttribute class
**namespace:** *[Serenity.ComponentModel](../README.md#serenity.componentmodel-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Indicates that the target property should use a "DateYear" editor.

```csharp
[AttributeUsage(AttributeTargets.All)]
public class DateYearEditorAttribute : CustomEditorAttribute
```

## Public Members

| name | description |
| --- | --- |
| [DateYearEditorAttribute](DateYearEditorAttribute/DateYearEditorAttribute.md)() | Initializes a new instance of the [`DateYearEditorAttribute`](DateYearEditorAttribute.md) class. |
| [Descending](DateYearEditorAttribute/Descending.md) { get; set; } | Gets or sets a value indicating whether the years should be listed in descending order. |
| [MaxYear](DateYearEditorAttribute/MaxYear.md) { get; set; } | Gets or sets the maximum year. It can be written as an integer value, or +50, -20 etc. corresponding to current year plus or minus years. |
| [MinYear](DateYearEditorAttribute/MinYear.md) { get; set; } | Gets or sets the minimum year. It can be written as an integer value, or +50, -20 etc. corresponding to current year plus or minus years. |
| const [Key](DateYearEditorAttribute/Key.md) | Editor type key |

## See Also

* class [CustomEditorAttribute](CustomEditorAttribute.md)
* **Source:** *[DateYearEditorAttribute.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Core/ComponentModel/PropertyGrid/EditorTypes/DateYearEditorAttribute.cs)*