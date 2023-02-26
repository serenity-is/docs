# ISiteAbsoluteUrl interface
**namespace:** *[Serenity.Abstractions](../README.md#serenity.abstractions-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Interface to access absolute base URL for current site, including the PathBase. Useful for reporting callbacks, or e-mails etc.

```csharp
public interface ISiteAbsoluteUrl
```

## Members

| name | description |
| --- | --- |
| [GetExternalUrl](ISiteAbsoluteUrl/GetExternalUrl.md)() | Returns the absolute external/public url of the current site, used to generate links for activation e-mails etc. The default implementation builds it from one of these in this order: 1) The current http request base url if available, 2) EnvironmentSettings:SiteExternalUrl setting |
| [GetInternalUrl](ISiteAbsoluteUrl/GetInternalUrl.md)() | Returns the absolute internal/local url of the current site, used to generate URLs for report tools like WKHTML, Puppeeteer etc. The default implementation builds it from one of these in this order: 1) EnvironmentSettings:SiteInternalUrl setting, 2) The current http request base url if available, 3) EnvironmentSettings:SiteExternalUrl setting |

## See Also

* **Source:** *[ISiteAbsoluteUrl.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Core/Interface/ISiteAbsoluteUrl.cs)*