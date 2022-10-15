# IntegerEditorAttribute class
**namespace:** *[Serenity.ComponentModel](../README.md#serenity.componentmodel-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Indicates that the target property should use a "Integer" editor.

```csharp
[AttributeUsage(AttributeTargets.All)]
public class IntegerEditorAttribute : CustomEditorAttribute
```

## Public Members

| name | description |
| --- | --- |
| [IntegerEditorAttribute](IntegerEditorAttribute/IntegerEditorAttribute.md)() | Initializes a new instance of the [`IntegerEditorAttribute`](IntegerEditorAttribute.md) class. |
| [AllowNegatives](IntegerEditorAttribute/AllowNegatives.md) { get; set; } | Gets or sets a value indicating whether the editor should allow negatives. |
| [MaxValue](IntegerEditorAttribute/MaxValue.md) { get; set; } | Gets or sets the maximum value. |
| [MinValue](IntegerEditorAttribute/MinValue.md) { get; set; } | Gets or sets the minimum value. |
| static [AllowNegativesByDefault](IntegerEditorAttribute/AllowNegativesByDefault.md) { get; set; } | Gets or sets a value indicating whether editors should allow negatives by default. This is a global setting that controls default of AllowNegatives property in this attribute. |
| const [Key](IntegerEditorAttribute/Key.md) | Editor type key |

## See Also

* class [CustomEditorAttribute](CustomEditorAttribute.md)
* **Source:** *[IntegerEditorAttribute.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Core/ComponentModel/PropertyGrid/EditorTypes/IntegerEditorAttribute.cs)*