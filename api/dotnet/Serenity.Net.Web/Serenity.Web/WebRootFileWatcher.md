# WebRootFileWatcher class
**namespace:** *[Serenity.Web](../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Net.Web](../README.md)*

Default implementation of [`IWebRootFileWatcher`](./IWebRootFileWatcher.md). It reuses physical file providers rooted at `wwwroot` / `staticwebassets` so that watching multiple files in the same directory does not create a new provider each time. Watching is only done in development.

```csharp
public class WebRootFileWatcher : IDisposable, IWebRootFileWatcher
```

| parameter | description |
| --- | --- |
| hostEnvironment | The web host environment. |

## Public Members

| name | description |
| --- | --- |
| [WebRootFileWatcher](WebRootFileWatcher/WebRootFileWatcher.md)(…) | Default implementation of [`IWebRootFileWatcher`](./IWebRootFileWatcher.md). It reuses physical file providers rooted at `wwwroot` / `staticwebassets` so that watching multiple files in the same directory does not create a new provider each time. Watching is only done in development. |
| [Dispose](WebRootFileWatcher/Dispose.md)() |  |
| [GetChangeToken](WebRootFileWatcher/GetChangeToken.md)(…) |  |
| [RegisterCallback](WebRootFileWatcher/RegisterCallback.md)(…) |  |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | *hostEnvironment* is `null`. |

## Remarks

Initializes a new instance of the [`WebRootFileWatcher`](./WebRootFileWatcher.md) class.

## See Also

* interface [IWebRootFileWatcher](./IWebRootFileWatcher.md)
* **Source:** *[WebRootFileWatcher.cs](https://github.com/serenity-is/Serenity/blob/9a2446d846f519fbbaf51efc2ecb18e288be61be/src/web/Common/WebRootFileWatcher.cs)*