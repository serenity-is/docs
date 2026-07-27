# TimeEditorAttribute class
**namespace:** *[Serenity.ComponentModel](../README.md#serenity.componentmodel-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Indicates that the target property should use a "Time (HH:mm)" editor. The editor does not support editing seconds or milliseconds. It is a simple dropdown editor that allows selecting a time between StartHour and EndHour Note that this editor type returns an integer value that is number of minutes from midnight. Use it only with Integer typed fields. You may use multiplier option to store seconds (60) or milliseconds (60000). Use TimeSpanEditor for TimeSpan fields.

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
| [Multiplier](TimeEditorAttribute/Multiplier.md) { get; set; } | Gets or sets the multiplier (default is 1 which is minutes, 60 to store seconds, 60000 to store ms) |
| [NoEmptyOption](TimeEditorAttribute/NoEmptyOption.md) { get; set; } | Gets or sets a value indicating whether empty option should be shown. |
| [StartHour](TimeEditorAttribute/StartHour.md) { get; set; } | Gets or sets the start hour between 0 and 23. |
| const [Key](TimeEditorAttribute/Key.md) | Editor type key |

## See Also

* class [CustomEditorAttribute](CustomEditorAttribute.md)
* **Source:** *[TimeEditorAttribute.cs](https://github.com/serenity-is/Serenity/blob/master/src/Core/ComponentModel/PropertyGrid/EditorTypes/TimeEditorAttribute.cs)*