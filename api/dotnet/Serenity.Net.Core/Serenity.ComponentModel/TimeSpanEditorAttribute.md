# TimeSpanEditorAttribute class
**namespace:** *[Serenity.ComponentModel](../README.md#serenity.componentmodel-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Indicates that the target property should use a "Time (HH:mm)" editor. The editor does not support editing seconds or milliseconds. It is a simple dropdown editor that allows selecting a time between StartHour and EndHour Note that this editor type returns a string value that is in format HH:mm. Use it only with TimeSpan typed fields. Use TimeEditor for integer fields.

```csharp
[AttributeUsage(AttributeTargets.All)]
public class TimeSpanEditorAttribute : CustomEditorAttribute
```

## Public Members

| name | description |
| --- | --- |
| [TimeSpanEditorAttribute](TimeSpanEditorAttribute/TimeSpanEditorAttribute.md)() | Initializes a new instance of the [`TimeSpanEditorAttribute`](TimeSpanEditorAttribute.md) class. |
| [EndHour](TimeSpanEditorAttribute/EndHour.md) { get; set; } | Gets or sets the end hour between 0 and 23. |
| [IntervalMinutes](TimeSpanEditorAttribute/IntervalMinutes.md) { get; set; } | Gets or sets the interval minutes. |
| [NoEmptyOption](TimeSpanEditorAttribute/NoEmptyOption.md) { get; set; } | Gets or sets a value indicating whether empty option should be shown. |
| [StartHour](TimeSpanEditorAttribute/StartHour.md) { get; set; } | Gets or sets the start hour between 0 and 23. |
| const [Key](TimeSpanEditorAttribute/Key.md) | Editor type key |

## See Also

* class [CustomEditorAttribute](CustomEditorAttribute.md)
* **Source:** *[TimeSpanEditorAttribute.cs](https://github.com/serenity-is/Serenity/blob/master/src/Core/ComponentModel/PropertyGrid/EditorTypes/TimeSpanEditorAttribute.cs)*