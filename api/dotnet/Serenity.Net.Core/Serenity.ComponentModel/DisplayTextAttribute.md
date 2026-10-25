# DisplayTextAttribute class
**namespace:** *[Serenity.ComponentModel](../README.md#serenity.componentmodel-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Specifies the display text for a property or class. Unlike DisplayNameAttribute, it can specify a local text key.

```csharp
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Event)]
public class DisplayTextAttribute : DisplayNameAttribute, IHasTextKey
```

## Public Members

| name | description |
| --- | --- |
| [DisplayTextAttribute](DisplayTextAttribute/DisplayTextAttribute.md)() | Initializes a new instance of the [`DisplayTextAttribute`](./DisplayTextAttribute.md) class with no display text. |
| [DisplayTextAttribute](DisplayTextAttribute/DisplayTextAttribute.md)(…) | Initializes a new instance of the [`DisplayTextAttribute`](./DisplayTextAttribute.md) class with the specified display text. |
| [TextKey](DisplayTextAttribute/TextKey.md) { get; set; } | Gets or sets the local text key for the display text. |

## Examples

[DisplayText("My Display Text", TextKey = "My.Text.Key")] // with key and invariant text [DisplayText(TextKey = "My.Text.Key")] // with only key and no text [DisplayText("My Display Text")] // with only invariant text, no key [DisplayText("Db.Text.Key")] // still with only invariant text, no key unlike DisplayNameAttribute.

## See Also

* interface [IHasTextKey](../Serenity.Services/IHasTextKey.md)
* **Source:** *[DisplayTextAttribute.cs](https://github.com/serenity-is/Serenity/blob/0c34357a17d56458ca5b7a3be25f42666b9eb050/src/core/ComponentModel/Common/DisplayTextAttribute.cs)*