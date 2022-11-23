# BaseReport class
**namespace:** *[Serenity.Reporting](../README.md#serenity.reporting-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Base class for reports that implement [`IReport`](IReport.md) and optionally [`IReportWithAdditionalData`](IReportWithAdditionalData.md)

```csharp
public abstract class BaseReport : IReport, IReportWithAdditionalData
```

## Public Members

| name | description |
| --- | --- |
| virtual [GetAdditionalData](BaseReport/GetAdditionalData.md)() |  |
| abstract [GetData](BaseReport/GetData.md)() |  |

## Protected Members

| name | description |
| --- | --- |
| [BaseReport](BaseReport/BaseReport.md)() | The default constructor. |

## See Also

* interface [IReport](IReport.md)
* interface [IReportWithAdditionalData](IReportWithAdditionalData.md)
* **Source:** *[BaseReport.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Services/Reporting/BaseReport.cs)*