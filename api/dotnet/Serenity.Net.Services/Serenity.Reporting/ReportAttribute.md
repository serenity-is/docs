# ReportAttribute class
**namespace:** *[Serenity.Reporting](../README.md#serenity.reporting-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Marks a class as a report.

```csharp
[AttributeUsage(AttributeTargets.Class)]
public class ReportAttribute : Attribute
```

| parameter | description |
| --- | --- |
| reportKey | The report key. If not passed it is calculated from the class name. |

## Public Members

| name | description |
| --- | --- |
| [ReportAttribute](ReportAttribute/ReportAttribute.md)(…) | Marks a class as a report. |
| [ReportKey](ReportAttribute/ReportKey.md) { get; } | Gets the report key. |

## Remarks

Initializes a new instance of the attribute.

## See Also

* **Source:** *[ReportAttribute.cs](https://github.com/serenity-is/Serenity/blob/03d9544633af3a843d9921adc3e91fceec981ad4/src/services/Reporting/ReportAttribute.cs)*