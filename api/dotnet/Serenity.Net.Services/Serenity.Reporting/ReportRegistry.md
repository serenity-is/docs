# ReportRegistry class
**namespace:** *[Serenity.Reporting](../README.md#serenity.reporting-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Default report registry implementation

```csharp
public class ReportRegistry : IReportRegistry
```

| parameter | description |
| --- | --- |
| typeSource | The type source to search report types in |
| permissions | Permission service |
| localizer | Text localizer |

## Public Members

| name | description |
| --- | --- |
| [ReportRegistry](ReportRegistry/ReportRegistry.md)(…) | Default report registry implementation |
| [GetAvailableReportsInCategory](ReportRegistry/GetAvailableReportsInCategory.md)(…) |  |
| [GetReport](ReportRegistry/GetReport.md)(…) | Returns report with the report key, optionally validating its permissions. |
| [HasAvailableReportsInCategory](ReportRegistry/HasAvailableReportsInCategory.md)(…) |  |
| static [GetReportCategoryTitle](ReportRegistry/GetReportCategoryTitle.md)(…) | Gets category title for a category key |
| static [GetReportKey](ReportRegistry/GetReportKey.md)(…) | Gets report key for the report type by looking at its ReportAttribute, returning type full name if it does not have a report key or the attribute. |
| class [Category](ReportRegistry.Category.md) | Model for a report category. |
| class [Report](ReportRegistry.Report.md) | Metadata for a registered report. |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | *typeSource*, *permissions* or *localizer* is `null`. |

## Remarks

Initializes a new instance of the class.

## See Also

* interface [IReportRegistry](./IReportRegistry.md)
* **Source:** *[ReportRegistry.cs](https://github.com/serenity-is/Serenity/blob/1a8f0b8d86a82010fb35e1c2b9f853493e7f539f/src/services/Reporting/Registry/ReportRegistry.cs)*