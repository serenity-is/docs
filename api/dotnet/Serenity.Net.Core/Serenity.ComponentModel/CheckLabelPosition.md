# CheckLabelPosition enumeration
**namespace:** *[Serenity.ComponentModel](../README.md#serenity.componentmodel-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Where the caption of a checkbox is, e.g. of a [`BooleanEditorAttribute`](./BooleanEditorAttribute.md) in a form field.

```csharp
public enum CheckLabelPosition
```

## Values

| name | value | description |
| --- | --- | --- |
| Start | `0` | The default: the caption is at the start (left in LTR) in the caption area, and the checkbox is after it, where the other editors start. |
| End | `1` | The checkbox is first, at the start of the field, and the caption is after it, on the end side (right in LTR). It saves horizontal space, and lets several checkboxes share a row. |
| EndAligned | `2` | Like End, but the caption area before the checkbox is left empty, so the checkbox starts where the other editors do. It is for a checkbox that is alone in its row, so it lines up with the editors above it. |

## See Also

* **Source:** *[CheckLabelPosition.cs](https://github.com/serenity-is/Serenity/blob/f1c09a9541fdeef86e31acb26c6974ab1d8c8936/src/core/ComponentModel/PropertyGrid/EditorTypes/CheckLabelPosition.cs)*