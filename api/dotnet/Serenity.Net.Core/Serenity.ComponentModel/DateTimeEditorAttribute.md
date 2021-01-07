# DateTimeEditorAttribute class
**namespace:** *[Serenity.ComponentModel](../README.md#serenity.componentmodel-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Indicates that the target property should use a "DateTime" editor.

```csharp
[AttributeUsage(AttributeTargets.All)]
public class DateTimeEditorAttribute : CustomEditorAttribute
```

## Public Members

| name | description |
| --- | --- |
| [DateTimeEditorAttribute](DateTimeEditorAttribute/DateTimeEditorAttribute.md)() | Initializes a new instance of the [`DateTimeEditorAttribute`](DateTimeEditorAttribute.md) class. |
| [EndHour](DateTimeEditorAttribute/EndHour.md) { get; set; } | Gets or sets the end hour between 0 and 23. |
| [IntervalMinutes](DateTimeEditorAttribute/IntervalMinutes.md) { get; set; } | Gets or sets the interval minutes, default is 5 mins. |
| [MaxValue](DateTimeEditorAttribute/MaxValue.md) { get; set; } | Gets or sets the maximum value. |
| [MinValue](DateTimeEditorAttribute/MinValue.md) { get; set; } | Gets or sets the minimum value. |
| [SqlMinMax](DateTimeEditorAttribute/SqlMinMax.md) { get; set; } | Gets or sets a value indicating whether SQL server min max dates should be used. |
| [StartHour](DateTimeEditorAttribute/StartHour.md) { get; set; } | Gets or sets the start hour between 0 and 23. |
| [UseUtc](DateTimeEditorAttribute/UseUtc.md) { get; set; } | Gets or sets a value indicating whether the editor should use UTC format. |

## See Also

* class [CustomEditorAttribute](CustomEditorAttribute.md)
* **Source:** *[DateTimeEditorAttribute.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Core/ComponentModel/PropertyGrid/EditorTypes/DateTimeEditorAttribute.cs)*