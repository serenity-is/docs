# ContentHashCache constructor
**namespace:** *[Serenity.Web](../../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Net.Web](../../README.md)*

Creates a new instance of the class

```csharp
public ContentHashCache(IOptions<CDNSettings> cdnSettings, IWebHostEnvironment hostEnvironment, 
    IHttpContextAccessor httpContextAccessor = null)
```

| parameter | description |
| --- | --- |
| cdnSettings | CDN settings |
| hostEnvironment | Host environment |
| httpContextAccessor | HTTP context accessor |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | hostEnvironment of httpContextAccessor is null |

## See Also

* class [CDNSettings](../ContentHashCache.CDNSettings.md)
* class [ContentHashCache](../ContentHashCache.md)