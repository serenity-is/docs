# ISiteAbsoluteUrl.GetInternalUrl method
**namespace:** *[Serenity.Abstractions](../../README.md#serenity.abstractions-namespace)*   **assembly**: *[Serenity.Net.Core](../../README.md)*

Returns the absolute internal/local url of the current site, used to generate URLs for report tools like WKHTML, Puppeeteer etc. The default implementation builds it from one of these in this order: 1) EnvironmentSettings:SiteInternalUrl setting, 2) The current http request base url if available, 3) EnvironmentSettings:SiteExternalUrl setting

```csharp
public string GetInternalUrl()
```

## See Also

* interface [ISiteAbsoluteUrl](../ISiteAbsoluteUrl.md)