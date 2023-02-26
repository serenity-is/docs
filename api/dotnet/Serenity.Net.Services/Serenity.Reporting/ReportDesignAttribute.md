# ReportDesignAttribute class
**namespace:** *[Serenity.Reporting](../README.md#serenity.reporting-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

The attribute used to determine the location of the report design which is usually a CSHTML file.

```csharp
[AttributeUsage(AttributeTargets.All)]
public class ReportDesignAttribute : Attribute
```

## Public Members

| name | description |
| --- | --- |
| [ReportDesignAttribute](ReportDesignAttribute/ReportDesignAttribute.md)(…) | Creates an instance of the attribute |
| [Design](ReportDesignAttribute/Design.md) { get; } | Returns the location of the design file which is passed via the constructor. |

## See Also

* **Source:** *[ReportDesignAttribute.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Services/Reporting/Rendering/ReportDesignAttribute.cs)*