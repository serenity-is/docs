# BooleanFormatterAttribute class
**namespace:** *[Serenity.ComponentModel](../README.md#serenity.componentmodel-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Sets formatting type to "Boolean"

```csharp
[AttributeUsage(AttributeTargets.All)]
public class BooleanFormatterAttribute : CustomFormatterAttribute
```

## Public Members

| name | description |
| --- | --- |
| [BooleanFormatterAttribute](BooleanFormatterAttribute/BooleanFormatterAttribute.md)() | Initializes a new instance of the [`BooleanFormatterAttribute`](BooleanFormatterAttribute.md) class. |
| [FalseIcon](BooleanFormatterAttribute/FalseIcon.md) { get; set; } | Gets or sets the icon corresponding to falsy value. |
| [FalseText](BooleanFormatterAttribute/FalseText.md) { get; set; } | Gets or sets the text corresponding to falsy value. |
| [ShowHint](BooleanFormatterAttribute/ShowHint.md) { get; set; } | Gets or sets a value indicating whether to show hint (text) on hover when text is not displayed next to checkbox icon. When displayed in header filter, defaults to false, otherwise defaults to true when showText is false. |
| [ShowText](BooleanFormatterAttribute/ShowText.md) { get; set; } | Gets or sets a value indicating whether to show text next to checkbox icon. Defaults to true |
| [TrueIcon](BooleanFormatterAttribute/TrueIcon.md) { get; set; } | Gets or sets the icon corresponding to truthy value. |
| [TrueText](BooleanFormatterAttribute/TrueText.md) { get; set; } | Gets or sets the text corresponding to truthy value. |
| const [Key](BooleanFormatterAttribute/Key.md) | Formatter type key |

## See Also

* class [CustomFormatterAttribute](CustomFormatterAttribute.md)
* **Source:** *[BooleanFormatterAttribute.cs](https://github.com/serenity-is/Serenity/blob/master/src/Core/ComponentModel/Columns/Formatting/BasicFormatterTypes/BooleanFormatterAttribute.cs)*