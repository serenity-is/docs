# IFileWatcherFactory.Create method

Creates a new file system watcher for the given path and filter.

```csharp
public IFileWatcher Create(string path, string filter)
```

| parameter | description |
| --- | --- |
| path | The directory path to watch. |
| filter | The file filter to watch for. |

## Return Value

A new [`IFileWatcher`](../IFileWatcher.md) instance.

## See Also

* interface [IFileWatcher](../IFileWatcher.md)
* interface [IFileWatcherFactory](../IFileWatcherFactory.md)