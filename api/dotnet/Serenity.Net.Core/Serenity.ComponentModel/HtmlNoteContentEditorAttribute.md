# HtmlNoteContentEditorAttribute class
**namespace:** *[Serenity.ComponentModel](../README.md#serenity.componentmodel-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Indicates that the target property should use an "HtmlNoteContent" editor. This is generally a CK editor with only basic functionality for notes enabled.

```csharp
[AttributeUsage(AttributeTargets.All)]
public class HtmlNoteContentEditorAttribute : CustomEditorAttribute
```

## Public Members

| name | description |
| --- | --- |
| [HtmlNoteContentEditorAttribute](HtmlNoteContentEditorAttribute/HtmlNoteContentEditorAttribute.md)() | Initializes a new instance of the [`HtmlNoteContentEditorAttribute`](HtmlNoteContentEditorAttribute.md) class. |
| [Cols](HtmlNoteContentEditorAttribute/Cols.md) { get; set; } | Gets or sets the cols of underlying textarea. |
| [Rows](HtmlNoteContentEditorAttribute/Rows.md) { get; set; } | Gets or sets the rows of underlying textarea. |
| const [Key](HtmlNoteContentEditorAttribute/Key.md) | Editor type key |

## See Also

* class [CustomEditorAttribute](CustomEditorAttribute.md)
* **Source:** *[HtmlNoteContentEditorAttribute.cs](https://github.com/serenity-is/Serenity/blob/a5013fdf777dbbd87589205ddffcb67f18bea673/src/core/ComponentModel/PropertyGrid/EditorTypes/HtmlNoteContentEditorAttribute.cs)*