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
| [DecimalEditorAttribute](DecimalEditorAttribute/DecimalEditorAttribute.md)() | Initializes a new instance of the [`DecimalEditorAttribute`](./DecimalEditorAttribute.md) class. |
| [AllowNegatives](DecimalEditorAttribute/AllowNegatives.md) { get; set; } | Gets or sets a value indicating whether to allow negatives. |
| [Decimals](DecimalEditorAttribute/Decimals.md) { get; set; } | Gets or sets the number of decimals allowed. |
| [MaxValue](DecimalEditorAttribute/MaxValue.md) { get; set; } | Gets or sets the maximum value. |
| [MinValue](DecimalEditorAttribute/MinValue.md) { get; set; } | Gets or sets the minimum value. |
| [PadDecimals](DecimalEditorAttribute/PadDecimals.md) { get; set; } | Gets or sets a value indicating whether to pad decimals with zero. |
| static [AllowNegativesByDefault](DecimalEditorAttribute/AllowNegativesByDefault.md) { get; set; } | Gets or sets a value indicating whether to allow negatives by default. This is a global setting that controls if decimal editors should allow negative values unless specified otherwise. Returns the local value if any is set through [`SetLocalAllowNegativesByDefault`](./DecimalEditorAttribute/SetLocalAllowNegativesByDefault.md), otherwise the default value. The local value should be used for unit tests. |
| const [Key](DecimalEditorAttribute/Key.md) | Editor type key |
| static [SetLocalAllowNegativesByDefault](DecimalEditorAttribute/SetLocalAllowNegativesByDefault.md)(…) | Sets the local value for [`AllowNegativesByDefault`](./DecimalEditorAttribute/AllowNegativesByDefault.md) for the current thread and async context. Useful for background tasks, async methods, and testing to set the value locally without affecting other threads or tests. |

## See Also

* class [CustomEditorAttribute](./CustomEditorAttribute.md)
* **Source:** *[DecimalEditorAttribute.cs](https://github.com/serenity-is/Serenity/blob/2c895c355fe09b3459b5091b6d2e792ced719b68/src/core/ComponentModel/PropertyGrid/EditorTypes/DecimalEditorAttribute.cs)*