# ContentHashCache constructor

Initializes a new instance of the [`ContentHashCache`](../ContentHashCache.md) class.

```csharp
public ContentHashCache(IOptions<CDNSettings> cdnSettings, IWebHostEnvironment hostEnvironment, 
    IHttpContextAccessor httpContextAccessor = null)
```

| parameter | description |
| --- | --- |
| cdnSettings | The CDN settings. |
| hostEnvironment | The host environment. |
| httpContextAccessor | The HTTP context accessor. |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | *hostEnvironment* is `null`. |

## See Also

* class [CDNSettings](../ContentHashCache.CDNSettings.md)
* class [ContentHashCache](../ContentHashCache.md)