# IFileWatcherFactory interface
**namespace:** *[Serenity.Web](../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Net.Web](../README.md)*

An abstract factory to create file system watchers

```csharp
public interface IFileWatcherFactory
```

## Members

| name | description |
| --- | --- |
| [Watchers](IFileWatcherFactory/Watchers.md) { get; } | Gets list of stored file watchers |
| [Create](IFileWatcherFactory/Create.md)(…) | Creates a new file system watcher for path and filter |
| [KeepAlive](IFileWatcherFactory/KeepAlive.md)(…) | Keeps the file watcher alive, usually keeping its instance reference in the watcher factory |

## See Also

* **Source:** *[IFileWatcherFactory.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Web/Common/IFileWatcherFactory.cs)*