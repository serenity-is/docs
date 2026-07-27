# CheckboxFormatterAttribute class
**namespace:** *[Serenity.ComponentModel](../README.md#serenity.componentmodel-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Sets formatting type to "Checkbox"

```csharp
[AttributeUsage(AttributeTargets.All)]
public class CheckboxFormatterAttribute : CustomFormatterAttribute
```

## Public Members

| name | description |
| --- | --- |
| [CheckboxFormatterAttribute](CheckboxFormatterAttribute/CheckboxFormatterAttribute.md)() | Initializes a new instance of the [`CheckboxFormatterAttribute`](CheckboxFormatterAttribute.md) class. |
| [FalseIcon](CheckboxFormatterAttribute/FalseIcon.md) { get; set; } | Gets or sets the icon corresponding to falsy value. |
| [FalseText](CheckboxFormatterAttribute/FalseText.md) { get; set; } | Gets or sets the text corresponding to falsy value. |
| [NullIcon](CheckboxFormatterAttribute/NullIcon.md) { get; set; } | Gets or sets the icon corresponding to nullish value. |
| [ShowHint](CheckboxFormatterAttribute/ShowHint.md) { get; set; } | Gets or sets a value indicating whether to show hint (text) on hover when text is not displayed next to checkbox icon. When displayed in header filter, defaults to false, otherwise defaults to true when showText is false and any of the texts are provided. |
| [ShowText](CheckboxFormatterAttribute/ShowText.md) { get; set; } | Gets or sets a value indicating whether to show text next to checkbox icon. When displayed in header filter, defaults to true, otherwise defaults to false. |
| [TrueIcon](CheckboxFormatterAttribute/TrueIcon.md) { get; set; } | Gets or sets the icon corresponding to truthy value. |
| [TrueText](CheckboxFormatterAttribute/TrueText.md) { get; set; } | Gets or sets the text corresponding to truthy value. |
| const [Key](CheckboxFormatterAttribute/Key.md) | Formatter type key |

## See Also

* class [CustomFormatterAttribute](CustomFormatterAttribute.md)
* **Source:** *[CheckboxFormatterAttribute.cs](https://github.com/serenity-is/Serenity/blob/master/src/Core/ComponentModel/Columns/Formatting/BasicFormatterTypes/CheckboxFormatterAttribute.cs)*