# EnvironmentSettings class
**namespace:** *[Serenity.Extensions](../README.md#serenity.extensions-namespace)*   **assembly**: *[Serenity.Extensions](../README.md)*

Settings related to the environment the application runs in, such as the externally and internally accessible URLs of the web site.

```csharp
public class EnvironmentSettings
```

## Public Members

| name | description |
| --- | --- |
| [EnvironmentSettings](EnvironmentSettings/EnvironmentSettings.md)() | The default constructor. |
| [InjectMarkupToHead](EnvironmentSettings/InjectMarkupToHead.md) { get; set; } | Optional markup to inject into head, can be used for analytics tags etc. |
| [IsPublicDemo](EnvironmentSettings/IsPublicDemo.md) { get; set; } | This was a flag used by Serenity Demo, but as it is using C# preprocessor directives now, this flag is obsolete |
| [SiteExternalUrl](EnvironmentSettings/SiteExternalUrl.md) { get; set; } | The externally accessible, public url of the web site, used for link generation in emails etc. The default implementation for ISiteAbsoluteUrl.GetExternalUrl() uses this value only when an HTTP request is not available |
| [SiteInternalUrl](EnvironmentSettings/SiteInternalUrl.md) { get; set; } | The internally accessible, local network url of the web site, used for URL generation for report tools to call back into the web site locally. If set, the default implementation for ISiteAbsoluteUrl.GetInternalUrl() will prefer this over the current request's base uri, and external URL setting. |
| const [SectionKey](EnvironmentSettings/SectionKey.md) | Default section key for environment settings. |

## See Also

* **Source:** *[EnvironmentSettings.cs](https://github.com/serenity-is/Serenity/blob/47a8f36cd87e4c2377c35f4a9f9c1c4ba0155f61/common-features/src/extensions/Modules/Options/EnvironmentSettings.cs)*