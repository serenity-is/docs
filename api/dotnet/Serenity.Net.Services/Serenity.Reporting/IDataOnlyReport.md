# IDataOnlyReport interface
**namespace:** *[Serenity.Reporting](../README.md#serenity.reporting-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Interface for reports that only contain data, e.g. no design. These are usually Excel/CSV etc. export type of reports.

```csharp
public interface IDataOnlyReport : IReport
```

## Members

| name | description |
| --- | --- |
| [GetColumnList](IDataOnlyReport/GetColumnList.md)() | Gets the list of columns to export. |

## See Also

* interface [IReport](./IReport.md)
* **Source:** *[IDataOnlyReport.cs](https://github.com/serenity-is/Serenity/blob/fa206546471018db1a28b90b807e2a73904efdfa/src/services/Reporting/DataReport/IDataOnlyReport.cs)*