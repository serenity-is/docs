# DescriptionTextAttribute class
**namespace:** *[Serenity.ComponentModel](../README.md#serenity.componentmodel-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Specifies the Description text for a property or class. Unlike DescriptionAttribute, it can specify a local text key.

```csharp
[AttributeUsage(AttributeTargets.All)]
public class DescriptionTextAttribute : DescriptionAttribute, IHasTextKey
```

## Public Members

| name | description |
| --- | --- |
| [DescriptionTextAttribute](DescriptionTextAttribute/DescriptionTextAttribute.md)() | Initializes a new instance of the [`DescriptionTextAttribute`](./DescriptionTextAttribute.md) class with no Description text. |
| [DescriptionTextAttribute](DescriptionTextAttribute/DescriptionTextAttribute.md)(…) | Initializes a new instance of the [`DescriptionTextAttribute`](./DescriptionTextAttribute.md) class with the specified Description text. |
| [TextKey](DescriptionTextAttribute/TextKey.md) { get; set; } | Gets or sets the local text key for the Description text. |

## Examples

[DescriptionText("My Description Text", TextKey = "My.Text.Key")] // with key and invariant text [DescriptionText(TextKey = "My.Text.Key")] // with only key and no text [DescriptionText("My Description Text")] // with only invariant text, no key [DescriptionText("Db.Text.Key")] // still with only invariant text, no key unlike DescriptionAttribute.

## See Also

* interface [IHasTextKey](../Serenity.Services/IHasTextKey.md)
* **Source:** *[DescriptionTextAttribute.cs](https://github.com/serenity-is/Serenity/blob/0c34357a17d56458ca5b7a3be25f42666b9eb050/src/core/ComponentModel/Common/DescriptionTextAttribute.cs)*