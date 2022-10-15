# HtmlContentEditorAttribute class
**namespace:** *[Serenity.ComponentModel](../README.md#serenity.componentmodel-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Indicates that the target property should use a "HtmlContent" editor. This is generally a CK editor that contains more functionalities compared to other ones.

```csharp
[AttributeUsage(AttributeTargets.All)]
public class HtmlContentEditorAttribute : CustomEditorAttribute
```

## Public Members

| name | description |
| --- | --- |
| [HtmlContentEditorAttribute](HtmlContentEditorAttribute/HtmlContentEditorAttribute.md)() | Initializes a new instance of the [`HtmlContentEditorAttribute`](HtmlContentEditorAttribute.md) class. |
| [Cols](HtmlContentEditorAttribute/Cols.md) { get; set; } | Gets or sets the cols for underlying textarea. |
| [Rows](HtmlContentEditorAttribute/Rows.md) { get; set; } | Gets or sets the rows for underlying textarea. |
| const [Key](HtmlContentEditorAttribute/Key.md) | Editor type key |

## See Also

* class [CustomEditorAttribute](CustomEditorAttribute.md)
* **Source:** *[HtmlContentEditorAttribute.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Core/ComponentModel/PropertyGrid/EditorTypes/HtmlContentEditorAttribute.cs)*