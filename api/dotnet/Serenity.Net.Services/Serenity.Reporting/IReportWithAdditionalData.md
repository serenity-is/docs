# IReportWithAdditionalData interface
**namespace:** *[Serenity.Reporting](../README.md#serenity.reporting-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

The interface for reports that return some type of additional data. For example, the system settings. This can be considered as additional datasets.

```csharp
public interface IReportWithAdditionalData
```

## Members

| name | description |
| --- | --- |
| [GetAdditionalData](IReportWithAdditionalData/GetAdditionalData.md)() | Should returns the additional data the report have as a dictionary of dataset key / dataset content, if any. |

## See Also

* **Source:** *[IReportWithAdditionalData.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Services/Reporting/IReportWithAdditionalData.cs)*