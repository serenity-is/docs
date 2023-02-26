# ISiteAbsoluteUrl.GetExternalUrl method
**namespace:** *[Serenity.Abstractions](../../README.md#serenity.abstractions-namespace)*   **assembly**: *[Serenity.Net.Core](../../README.md)*

Returns the absolute external/public url of the current site, used to generate links for activation e-mails etc. The default implementation builds it from one of these in this order: 1) The current http request base url if available, 2) EnvironmentSettings:SiteExternalUrl setting

```csharp
public string GetExternalUrl()
```

## See Also

* interface [ISiteAbsoluteUrl](../ISiteAbsoluteUrl.md)