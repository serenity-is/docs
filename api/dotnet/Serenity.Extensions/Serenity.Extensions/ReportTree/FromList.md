# ReportTree.FromList method
**namespace:** *[Serenity.Extensions](../../README.md#serenity.extensions-namespace)*   **assembly**: *[Serenity.Extensions](../../README.md)*

Builds a report tree from the specified reports.

```csharp
public static ReportTree FromList(IEnumerable<Report> reports, ITextLocalizer localizer, 
    string rootPath = null, string categoryOrder = null)
```

| parameter | description |
| --- | --- |
| reports | The reports. |
| localizer | The text localizer. |
| rootPath | The root path. |
| categoryOrder | The category order. |

## Return Value

The report tree.

## See Also

* class [Report](../Serenity.Net.Services/../../Serenity.Reporting/ReportRegistry.Report.md)
* interface [ITextLocalizer](../Serenity.Net.Core/../../Serenity/ITextLocalizer.md)
* class [ReportTree](../ReportTree.md)