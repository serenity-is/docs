# UseWKHtmlToPdfAttribute class
**namespace:** *[Serenity.Reporting](../README.md#serenity.reporting-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Marks a report to determine if it should use WKHTML instead of another converter, e.g. Puppeteer etc. (only if configured in service provider).

```csharp
[AttributeUsage(AttributeTargets.All)]
public class UseWKHtmlToPdfAttribute : Attribute
```

| parameter | description |
| --- | --- |
| value |  |

## Public Members

| name | description |
| --- | --- |
| [UseWKHtmlToPdfAttribute](UseWKHtmlToPdfAttribute/UseWKHtmlToPdfAttribute.md)(…) | Marks a report to determine if it should use WKHTML instead of another converter, e.g. Puppeteer etc. (only if configured in service provider). |
| [Value](UseWKHtmlToPdfAttribute/Value.md) { get; } | Gets the value |

## Remarks

Creates a new instance of the attribute

## See Also

* **Source:** *[UseWKHtmlToPdfAttribute.cs](https://github.com/serenity-is/Serenity/blob/master/src/Services/Reporting/HtmlToPdf/UseWKHtmlToPdfAttribute.cs)*