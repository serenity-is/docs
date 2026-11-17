# BooleanEditorAttribute class
**namespace:** *[Serenity.ComponentModel](../README.md#serenity.componentmodel-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Indicates that the target property should use a "Boolean" editor.

```csharp
[AttributeUsage(AttributeTargets.All)]
public class BooleanEditorAttribute : CustomEditorAttribute
```

## Public Members

| name | description |
| --- | --- |
| [BooleanEditorAttribute](BooleanEditorAttribute/BooleanEditorAttribute.md)() | Initializes a new instance of the [`BooleanEditorAttribute`](./BooleanEditorAttribute.md) class. |
| [LabelPosition](BooleanEditorAttribute/LabelPosition.md) { get; set; } | Gets or sets where the caption of the field is, at the start in the caption area by default, or after the checkbox, which is useful for fitting several checkboxes in one row, see [`CheckLabelPosition`](./CheckLabelPosition.md). |
| const [Key](BooleanEditorAttribute/Key.md) | Editor type key |

## See Also

* class [CustomEditorAttribute](./CustomEditorAttribute.md)
* **Source:** *[BooleanEditorAttribute.cs](https://github.com/serenity-is/Serenity/blob/f1c09a9541fdeef86e31acb26c6974ab1d8c8936/src/core/ComponentModel/PropertyGrid/EditorTypes/BooleanEditorAttribute.cs)*