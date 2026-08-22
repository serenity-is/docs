# IFileWatcherFactory interface
**namespace:** *[Serenity.Web](../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Net.Web](../README.md)*

An abstract factory for creating file system watchers.

```csharp
public interface IFileWatcherFactory
```

## Members

| name | description |
| --- | --- |
| [Watchers](IFileWatcherFactory/Watchers.md) { get; } | Gets the list of stored file watchers. |
| [Create](IFileWatcherFactory/Create.md)(…) | Creates a new file system watcher for the given path and filter. |
| [KeepAlive](IFileWatcherFactory/KeepAlive.md)(…) | Keeps the file watcher alive, usually by retaining its instance reference in the watcher factory. |

## See Also

* **Source:** *[IFileWatcherFactory.cs](https://github.com/serenity-is/Serenity/blob/a5013fdf777dbbd87589205ddffcb67f18bea673/src/web/Common/IFileWatcherFactory.cs)*