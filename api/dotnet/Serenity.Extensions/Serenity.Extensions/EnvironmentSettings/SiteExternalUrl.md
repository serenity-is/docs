# EnvironmentSettings.SiteExternalUrl property
**namespace:** *[Serenity.Extensions](../../README.md#serenity.extensions-namespace)*   **assembly**: *[Serenity.Extensions](../../README.md)*

The externally accessible, public url of the web site, used for link generation in emails etc. The default implementation for ISiteAbsoluteUrl.GetExternalUrl() uses this value only when an HTTP request is not available

```csharp
public string SiteExternalUrl { get; set; }
```

## See Also

* class [EnvironmentSettings](../EnvironmentSettings.md)