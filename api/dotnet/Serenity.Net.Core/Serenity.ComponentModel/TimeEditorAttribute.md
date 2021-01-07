# TimeEditorAttribute class
**namespace:** *[Serenity.ComponentModel](../README.md#serenity.componentmodel-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Indicates that the target property should use a "Time" editor.

```csharp
[AttributeUsage(AttributeTargets.All)]
public class TimeEditorAttribute : CustomEditorAttribute
```

## Public Members

| name | description |
| --- | --- |
| [TimeEditorAttribute](TimeEditorAttribute/TimeEditorAttribute.md)() | Initializes a new instance of the [`TimeEditorAttribute`](TimeEditorAttribute.md) class. |
| [EndHour](TimeEditorAttribute/EndHour.md) { get; set; } | Gets or sets the end hour between 0 and 23. |
| [IntervalMinutes](TimeEditorAttribute/IntervalMinutes.md) { get; set; } | Gets or sets the interval minutes. |
| [NoEmptyOption](TimeEditorAttribute/NoEmptyOption.md) { get; set; } | Gets or sets a value indicating whether empty option should be shown. |
| [StartHour](TimeEditorAttribute/StartHour.md) { get; set; } | Gets or sets the start hour between 0 and 23. |

## See Also

* class [CustomEditorAttribute](CustomEditorAttribute.md)
* **Source:** *[TimeEditorAttribute.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Core/ComponentModel/PropertyGrid/EditorTypes/TimeEditorAttribute.cs)*