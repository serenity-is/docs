# ReportRetrieveResponse class
**namespace:** *[Serenity.Reporting](../README.md#serenity.reporting-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Response model for a report retrieve request.

```csharp
public class ReportRetrieveResponse : ServiceResponse
```

## Public Members

| name | description |
| --- | --- |
| [ReportRetrieveResponse](ReportRetrieveResponse/ReportRetrieveResponse.md)() | The default constructor. |
| [InitialSettings](ReportRetrieveResponse/InitialSettings.md) { get; set; } | The initial settings for report parameters. |
| [IsDataOnlyReport](ReportRetrieveResponse/IsDataOnlyReport.md) { get; set; } | True if the report is an [`IDataOnlyReport`](IDataOnlyReport.md) |
| [IsExternalReport](ReportRetrieveResponse/IsExternalReport.md) { get; set; } | True if the report is an [`IExternalReport`](IExternalReport.md) |
| [Properties](ReportRetrieveResponse/Properties.md) { get; set; } | List of parameters as property items to show in report execution form. |
| [ReportKey](ReportRetrieveResponse/ReportKey.md) { get; set; } | The report key. |
| [Title](ReportRetrieveResponse/Title.md) { get; set; } | The title of the report. |

## See Also

* class [ServiceResponse](../Serenity.Services/ServiceResponse.md)
* **Source:** *[ReportRetrieveResponse.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Services/Reporting/Retrieve/ReportRetrieveResponse.cs)*