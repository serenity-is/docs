# UseWKHtmlToPdfAttribute class
**namespace:** *[Serenity.Reporting](../README.md#serenity.reporting-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Marks a report to determine if it should use WKHTML instead of another converter, e.g. Puppeteer etc. (only if configured in service provider).

```csharp
[AttributeUsage(AttributeTargets.All)]
public class UseWKHtmlToPdfAttribute : Attribute
```

| parameter | description |
| --- | --- |
| value | Whether the report should use WKHTML to PDF. |

## Public Members

| name | description |
| --- | --- |
| [UseWKHtmlToPdfAttribute](UseWKHtmlToPdfAttribute/UseWKHtmlToPdfAttribute.md)(…) | Marks a report to determine if it should use WKHTML instead of another converter, e.g. Puppeteer etc. (only if configured in service provider). |
| [Value](UseWKHtmlToPdfAttribute/Value.md) { get; } | Gets a value indicating whether WKHTML to PDF should be used. |

## Remarks

Initializes a new instance of the attribute.

## See Also

* **Source:** *[UseWKHtmlToPdfAttribute.cs](https://github.com/serenity-is/Serenity/blob/master/src/Services/Reporting/HtmlToPdf/UseWKHtmlToPdfAttribute.cs)*