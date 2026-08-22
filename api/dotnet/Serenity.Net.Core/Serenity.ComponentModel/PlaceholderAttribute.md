# PlaceholderAttribute class
**namespace:** *[Serenity.ComponentModel](../README.md#serenity.componentmodel-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Sets a placeholder for a form field. Placeholder text is shown inside the editor when its value is empty. Only editors using basic inputs and the Select2 editor support this.

```csharp
[AttributeUsage(AttributeTargets.All)]
public class PlaceholderAttribute : Attribute
```

| parameter | description |
| --- | --- |
| value | The value. |

## Public Members

| name | description |
| --- | --- |
| [PlaceholderAttribute](PlaceholderAttribute/PlaceholderAttribute.md)(…) | Sets a placeholder for a form field. Placeholder text is shown inside the editor when its value is empty. Only editors using basic inputs and the Select2 editor support this. |
| [Value](PlaceholderAttribute/Value.md) { get; } | Gets the value. |

## Remarks

Initializes a new instance of the [`PlaceholderAttribute`](PlaceholderAttribute.md) class.

## See Also

* **Source:** *[PlaceholderAttribute.cs](https://github.com/serenity-is/Serenity/blob/a5013fdf777dbbd87589205ddffcb67f18bea673/src/core/ComponentModel/PropertyGrid/PlaceholderAttribute.cs)*