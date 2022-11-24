# ReportRegistry.GetReport method
**namespace:** *[Serenity.Reporting](../../README.md#serenity.reporting-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Returns report with the report key, optionally validating its permissions.

```csharp
public Report GetReport(string reportKey, bool validatePermission = true)
```

| parameter | description |
| --- | --- |
| reportKey | Report key |
| validatePermission | Validate permission. Default true. |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | reportKey is n ull |

## See Also

* class [Report](../ReportRegistry.Report.md)
* class [ReportRegistry](../ReportRegistry.md)