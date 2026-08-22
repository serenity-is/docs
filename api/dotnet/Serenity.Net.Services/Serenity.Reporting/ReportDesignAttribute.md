# ReportDesignAttribute class
**namespace:** *[Serenity.Reporting](../README.md#serenity.reporting-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

The attribute used to determine the location of the report design, which is usually a CSHTML file.

```csharp
[AttributeUsage(AttributeTargets.All)]
public class ReportDesignAttribute : Attribute
```

| parameter | description |
| --- | --- |
| design | The location of the design file. |

## Public Members

| name | description |
| --- | --- |
| [ReportDesignAttribute](ReportDesignAttribute/ReportDesignAttribute.md)(…) | The attribute used to determine the location of the report design, which is usually a CSHTML file. |
| [Design](ReportDesignAttribute/Design.md) { get; } | Gets the location of the design file which is passed via the constructor. |

## Remarks

Initializes a new instance of the attribute.

## See Also

* **Source:** *[ReportDesignAttribute.cs](https://github.com/serenity-is/Serenity/blob/a5013fdf777dbbd87589205ddffcb67f18bea673/src/services/Reporting/Rendering/ReportDesignAttribute.cs)*