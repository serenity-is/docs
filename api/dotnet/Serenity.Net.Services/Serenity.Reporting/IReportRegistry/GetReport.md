# IReportRegistry.GetReport method
**namespace:** *[Serenity.Reporting](../../README.md#serenity.reporting-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Gets a report by its key.

```csharp
public Report GetReport(string reportKey, bool validatePermission = true)
```

| parameter | description |
| --- | --- |
| reportKey | Report key |
| validatePermission | Should validate the permission for report before returning. |

## Return Value

The report with the given key, or `null` if it is not found.

## See Also

* class [Report](../ReportRegistry.Report.md)
* interface [IReportRegistry](../IReportRegistry.md)