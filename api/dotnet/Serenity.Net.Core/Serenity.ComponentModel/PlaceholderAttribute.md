# PlaceholderAttribute class
**namespace:** *[Serenity.ComponentModel](../README.md#serenity.componentmodel-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Sets a placeholder for a form field. Placeholder text is shown inside the editor when its value is empty. Only editors using basic inputs and the Select2 editor support this.

```csharp
[AttributeUsage(AttributeTargets.All)]
public class PlaceholderAttribute : Attribute, IHasTextKey
```

| parameter | description |
| --- | --- |
| value | The value. |

## Public Members

| name | description |
| --- | --- |
| [PlaceholderAttribute](PlaceholderAttribute/PlaceholderAttribute.md)() | Initializes a new instance of the [`PlaceholderAttribute`](./PlaceholderAttribute.md) class with no placeholder text. Maybe used to specify a TextKey instead. |
| [PlaceholderAttribute](PlaceholderAttribute/PlaceholderAttribute.md)(…) | Sets a placeholder for a form field. Placeholder text is shown inside the editor when its value is empty. Only editors using basic inputs and the Select2 editor support this. |
| [TextKey](PlaceholderAttribute/TextKey.md) { get; set; } | Gets or sets the local text key for the placeholder text. |
| [Value](PlaceholderAttribute/Value.md) { get; } | Gets the value. |

## Remarks

Initializes a new instance of the [`PlaceholderAttribute`](./PlaceholderAttribute.md) class.

## See Also

* interface [IHasTextKey](../Serenity.Services/IHasTextKey.md)
* **Source:** *[PlaceholderAttribute.cs](https://github.com/serenity-is/Serenity/blob/0c34357a17d56458ca5b7a3be25f42666b9eb050/src/core/ComponentModel/PropertyGrid/PlaceholderAttribute.cs)*