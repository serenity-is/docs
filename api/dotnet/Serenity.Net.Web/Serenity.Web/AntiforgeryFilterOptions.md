# AntiforgeryFilterOptions class
**namespace:** *[Serenity.Web](../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Net.Web](../README.md)*

Options for AutoValidateAntiforgeryIgnoreBearerFilter.

```csharp
public class AntiforgeryFilterOptions
```

## Public Members

| name | description |
| --- | --- |
| [AntiforgeryFilterOptions](AntiforgeryFilterOptions/AntiforgeryFilterOptions.md)() | The default constructor. |
| [SkipValidationHeaderName](AntiforgeryFilterOptions/SkipValidationHeaderName.md) { get; set; } | Gets or sets the name of the HTTP header that, if present in a request, causes the CSRF validation to be skipped. |
| [SkipValidationHeaderValue](AntiforgeryFilterOptions/SkipValidationHeaderValue.md) { get; set; } | Gets or sets the header value for [`SkipValidationHeaderName`](./AntiforgeryFilterOptions/SkipValidationHeaderName.md) that, if present in a request, causes the operation to be skipped. |

## See Also

* **Source:** *[AntiforgeryFilterOptions.cs](https://github.com/serenity-is/Serenity/blob/b25593854f2e2d2560030f357d1bb7a1cbd85e65/src/web/Mvc/Antiforgery/AntiforgeryFilterOptions.cs)*