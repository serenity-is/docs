# ContentHashCache constructor (1 of 2)

Initializes a new instance with a private memory cache.

```csharp
public ContentHashCache(IOptions<CDNSettings> cdnSettings, IWebHostEnvironment hostEnvironment, 
    IHttpContextAccessor? httpContextAccessor = null, IWebRootFileWatcher? fileWatcher = null)
```

| parameter | description |
| --- | --- |
| cdnSettings | The CDN settings. |
| hostEnvironment | The host environment. |
| httpContextAccessor | The HTTP context accessor. |
| fileWatcher | The web root file watcher, used to invalidate hashes in development. |

## See Also

* class [CDNSettings](../ContentHashCache.CDNSettings.md)
* interface [IWebRootFileWatcher](../IWebRootFileWatcher.md)
* class [ContentHashCache](../ContentHashCache.md)

---

# ContentHashCache constructor (2 of 2)

Initializes a new instance of the [`ContentHashCache`](../ContentHashCache.md) class.

```csharp
public ContentHashCache(IOptions<CDNSettings> cdnSettings, IMemoryCache memoryCache, 
    IWebHostEnvironment hostEnvironment, IHttpContextAccessor? httpContextAccessor = null, 
    IWebRootFileWatcher? fileWatcher = null)
```

| parameter | description |
| --- | --- |
| cdnSettings | The CDN settings. |
| memoryCache | The memory cache. |
| hostEnvironment | The host environment. |
| httpContextAccessor | The HTTP context accessor. |
| fileWatcher | The web root file watcher, used to invalidate hashes in development. |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | *hostEnvironment* is `null`. |

## See Also

* class [CDNSettings](../ContentHashCache.CDNSettings.md)
* interface [IWebRootFileWatcher](../IWebRootFileWatcher.md)
* class [ContentHashCache](../ContentHashCache.md)