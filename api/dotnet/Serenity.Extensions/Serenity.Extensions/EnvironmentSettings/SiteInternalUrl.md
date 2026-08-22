# EnvironmentSettings.SiteInternalUrl property
**namespace:** *[Serenity.Extensions](../../README.md#serenity.extensions-namespace)*   **assembly**: *[Serenity.Extensions](../../README.md)*

The internally accessible, local network url of the web site, used for URL generation for report tools to call back into the web site locally. If set, the default implementation for ISiteAbsoluteUrl.GetInternalUrl() will prefer this over the current request's base uri, and external URL setting.

```csharp
public string SiteInternalUrl { get; set; }
```

## See Also

* class [EnvironmentSettings](../EnvironmentSettings.md)