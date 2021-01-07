# HtmlNoteContentEditorAttribute class
**namespace:** *[Serenity.ComponentModel](../README.md#serenity.componentmodel-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Indicates that the target property should use a "HtmlNoteContent" editor. This is generally a CK editor with only basic functionality for notes enabled.

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

## See Also

* class [CustomEditorAttribute](CustomEditorAttribute.md)
* **Source:** *[HtmlNoteContentEditorAttribute.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Core/ComponentModel/PropertyGrid/EditorTypes/HtmlNoteContentEditorAttribute.cs)*