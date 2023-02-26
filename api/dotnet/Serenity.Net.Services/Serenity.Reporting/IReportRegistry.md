# IReportRegistry interface
**namespace:** *[Serenity.Reporting](../README.md#serenity.reporting-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Abstraction for the registry which holds and allows querying list of available reports by their keys and categories.

```csharp
public interface IReportRegistry
```

## Members

| name | description |
| --- | --- |
| [GetAvailableReportsInCategory](IReportRegistry/GetAvailableReportsInCategory.md)(…) | Gets all available reports in category, for example "Northwind". This only returns reports that current user has access to, by checking their permissions if any. |
| [GetReport](IReportRegistry/GetReport.md)(…) | Gets a report by its key. |
| [HasAvailableReportsInCategory](IReportRegistry/HasAvailableReportsInCategory.md)(…) | Returns true if there are reports in the category passed. |

## See Also

* **Source:** *[IReportRegistry.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Services/Reporting/Registry/IReportRegistry.cs)*