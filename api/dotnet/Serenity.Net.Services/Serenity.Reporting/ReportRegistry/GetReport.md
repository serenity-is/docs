# ReportRegistry.GetReport method

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
| ArgumentNullException | *reportKey* is `null` or empty. |

## See Also

* class [Report](../ReportRegistry.Report.md)
* class [ReportRegistry](../ReportRegistry.md)