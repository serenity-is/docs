# HtmlReportContentEditorAttribute class
**namespace:** *[Serenity.ComponentModel](../README.md#serenity.componentmodel-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Indicates that the target property should use a "HtmlReportContent" editor. This is generally a CK editor with only functionality compatible with common reporting tools like SSRS, Telerik, DevExpress etc. enabled.

```csharp
[AttributeUsage(AttributeTargets.All)]
public class HtmlReportContentEditorAttribute : CustomEditorAttribute
```

## Public Members

| name | description |
| --- | --- |
| [HtmlReportContentEditorAttribute](HtmlReportContentEditorAttribute/HtmlReportContentEditorAttribute.md)() | Initializes a new instance of the [`HtmlReportContentEditorAttribute`](HtmlReportContentEditorAttribute.md) class. |
| [Cols](HtmlReportContentEditorAttribute/Cols.md) { get; set; } | Gets or sets the cols for underlying textarea. |
| [Rows](HtmlReportContentEditorAttribute/Rows.md) { get; set; } | Gets or sets the rows for underlying textarea. |
| const [Key](HtmlReportContentEditorAttribute/Key.md) | Editor type key |

## See Also

* class [CustomEditorAttribute](CustomEditorAttribute.md)
* **Source:** *[HtmlReportContentEditorAttribute.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Core/ComponentModel/PropertyGrid/EditorTypes/HtmlReportContentEditorAttribute.cs)*