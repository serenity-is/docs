# WebRootFileWatcher constructor

Default implementation of [`IWebRootFileWatcher`](../IWebRootFileWatcher.md). It reuses physical file providers rooted at `wwwroot` / `staticwebassets` so that watching multiple files in the same directory does not create a new provider each time. Watching is only done in development.

```csharp
public WebRootFileWatcher(IWebHostEnvironment hostEnvironment)
```

| parameter | description |
| --- | --- |
| hostEnvironment | The web host environment. |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | *hostEnvironment* is `null`. |

## Remarks

Initializes a new instance of the [`WebRootFileWatcher`](../WebRootFileWatcher.md) class.

## See Also

* class [WebRootFileWatcher](../WebRootFileWatcher.md)