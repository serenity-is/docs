# ReportAttribute class
**namespace:** *[Serenity.Reporting](../README.md#serenity.reporting-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Marks a class as Report

```csharp
[AttributeUsage(AttributeTargets.All)]
public class ReportAttribute : Attribute
```

| parameter | description |
| --- | --- |
| reportKey | The report key. If not passed it is calculated from the class name. |

## Public Members

| name | description |
| --- | --- |
| [ReportAttribute](ReportAttribute/ReportAttribute.md)(…) | Marks a class as Report |
| [ReportKey](ReportAttribute/ReportKey.md) { get; } | The report key. |

## Remarks

Creates an instance of the attribute

## See Also

* **Source:** *[ReportAttribute.cs](https://github.com/serenity-is/Serenity/blob/master/src/Services/Reporting/ReportAttribute.cs)*