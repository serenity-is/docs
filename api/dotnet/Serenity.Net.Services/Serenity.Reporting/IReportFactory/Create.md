# IReportFactory.Create method
**namespace:** *[Serenity.Reporting](../../README.md#serenity.reporting-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Creates a report for the given report key

```csharp
public IReport Create(string reportKey, string reportParams, bool validatePermission = true)
```

| parameter | description |
| --- | --- |
| reportKey | Report key |
| reportParams | Optional JSON options to set in the report |
| validatePermission | True if the permission for the report should be validated |

## See Also

* interface [IReport](../IReport.md)
* interface [IReportFactory](../IReportFactory.md)