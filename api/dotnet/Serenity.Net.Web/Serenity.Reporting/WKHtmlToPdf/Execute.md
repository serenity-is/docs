# WKHtmlToPdf.Execute method
**namespace:** *[Serenity.Reporting](../../README.md#serenity.reporting-namespace)*   **assembly**: *[Serenity.Net.Web](../../README.md)*

Executes the converter process and returns the PDF bytes.

```csharp
public byte[] Execute()
```

## Return Value

The generated PDF bytes.

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | [`ExecutablePath`](ExecutablePath.md) or [`Url`](Url.md) is `null`. |
| InvalidOperationException | An error occurred during process execution. |

## See Also

* class [WKHtmlToPdf](../WKHtmlToPdf.md)