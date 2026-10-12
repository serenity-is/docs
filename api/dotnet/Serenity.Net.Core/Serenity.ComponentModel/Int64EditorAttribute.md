# Int64EditorAttribute class
**namespace:** *[Serenity.ComponentModel](../README.md#serenity.componentmodel-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Indicates that the target property should use a "Int64" editor.

```csharp
[AttributeUsage(AttributeTargets.All)]
public class Int64EditorAttribute : CustomEditorAttribute
```

## Public Members

| name | description |
| --- | --- |
| [Int64EditorAttribute](Int64EditorAttribute/Int64EditorAttribute.md)() | Initializes a new instance of the [`Int64EditorAttribute`](./Int64EditorAttribute.md) class. |
| [AllowNegatives](Int64EditorAttribute/AllowNegatives.md) { get; set; } | Gets or sets a value indicating whether the editor should allow negatives. |
| [MaxValue](Int64EditorAttribute/MaxValue.md) { get; set; } | Gets or sets the maximum value. |
| [MinValue](Int64EditorAttribute/MinValue.md) { get; set; } | Gets or sets the minimum value. |
| const [Key](Int64EditorAttribute/Key.md) | Editor type key |

## See Also

* class [CustomEditorAttribute](./CustomEditorAttribute.md)
* **Source:** *[Int64EditorAttribute.cs](https://github.com/serenity-is/Serenity/blob/3d68185adc9ca553692b97b9f6c6c7321881b983/src/core/ComponentModel/PropertyGrid/EditorTypes/Int64EditorAttribute.cs)*