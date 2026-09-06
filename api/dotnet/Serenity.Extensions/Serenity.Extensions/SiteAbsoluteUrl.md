# SiteAbsoluteUrl class
**namespace:** *[Serenity.Extensions](../README.md#serenity.extensions-namespace)*   **assembly**: *[Serenity.Extensions](../README.md)*

Default implementation for ISiteAbsoluteUrl

```csharp
public class SiteAbsoluteUrl : ISiteAbsoluteUrl
```

## Public Members

| name | description |
| --- | --- |
| [SiteAbsoluteUrl](SiteAbsoluteUrl/SiteAbsoluteUrl.md)(…) | Default implementation for ISiteAbsoluteUrl |
| virtual [GetExternalUrl](SiteAbsoluteUrl/GetExternalUrl.md)() | Gets the external URL of the web site, throwing if it cannot be determined. |
| virtual [GetInternalUrl](SiteAbsoluteUrl/GetInternalUrl.md)() | Gets the internal URL of the web site, throwing if it cannot be determined. |

## Protected Members

| name | description |
| --- | --- |
| readonly [environmentSettings](SiteAbsoluteUrl/environmentSettings.md) | The environment settings used to resolve the internal and external URLs. |
| readonly [httpContextAccessor](SiteAbsoluteUrl/httpContextAccessor.md) | The HTTP context accessor used to resolve the current request's base URI. |
| virtual [TryGetExternalUrl](SiteAbsoluteUrl/TryGetExternalUrl.md)() | Tries to get the external URL from the current request or the configured site external URL. |
| virtual [TryGetInternalUrl](SiteAbsoluteUrl/TryGetInternalUrl.md)() | Tries to get the internal URL, falling back to the external URL when no internal URL is configured. |

## See Also

* interface [ISiteAbsoluteUrl](../../Serenity.Net.Core/Serenity.Abstractions/ISiteAbsoluteUrl.md)
* **Source:** *[SiteAbsoluteUrl.cs](https://github.com/serenity-is/Serenity/blob/47a8f36cd87e4c2377c35f4a9f9c1c4ba0155f61/common-features/src/extensions/Modules/Options/SiteAbsoluteUrl.cs)*