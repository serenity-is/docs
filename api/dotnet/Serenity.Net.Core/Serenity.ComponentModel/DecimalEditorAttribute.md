# DecimalEditorAttribute class
**namespace:** *[Serenity.ComponentModel](../README.md#serenity.componentmodel-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Indicates that the target property should use a "Decimal" editor.

```csharp
[AttributeUsage(AttributeTargets.All)]
public class DecimalEditorAttribute : CustomEditorAttribute
```

## Public Members

| name | description |
| --- | --- |
| [DecimalEditorAttribute](DecimalEditorAttribute/DecimalEditorAttribute.md)() | Initializes a new instance of the [`DecimalEditorAttribute`](DecimalEditorAttribute.md) class. |
| [AllowNegatives](DecimalEditorAttribute/AllowNegatives.md) { get; set; } | Gets or sets a value indicating whether to allow negatives. |
| [Decimals](DecimalEditorAttribute/Decimals.md) { get; set; } | Gets or sets the number of decimals allowed. |
| [MaxValue](DecimalEditorAttribute/MaxValue.md) { get; set; } | Gets or sets the maximum value. |
| [MinValue](DecimalEditorAttribute/MinValue.md) { get; set; } | Gets or sets the minimum value. |
| [PadDecimals](DecimalEditorAttribute/PadDecimals.md) { get; set; } | Gets or sets a value indicating whether to pad decimals with zero. |
| static [AllowNegativesByDefault](DecimalEditorAttribute/AllowNegativesByDefault.md) { get; set; } | Gets or sets a value indicating whether to allow negatives by default. This is a global setting that controls if decimal editors should allow negative values unless specified otherwise. |

## See Also

* class [CustomEditorAttribute](CustomEditorAttribute.md)
* **Source:** *[DecimalEditorAttribute.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Core/ComponentModel/PropertyGrid/EditorTypes/DecimalEditorAttribute.cs)*