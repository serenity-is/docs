# IFileWatcher interface
**namespace:** *[Serenity.Web](../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Net.Web](../README.md)*

File system watcher abstraction

```csharp
public interface IFileWatcher
```

## Members

| name | description |
| --- | --- |
| [Filter](IFileWatcher/Filter.md) { get; } | Watch filter |
| [Path](IFileWatcher/Path.md) { get; } | Watch path |
| event [Changed](IFileWatcher/Changed.md) | Event that is raised when a file changed |
| [RaiseChanged](IFileWatcher/RaiseChanged.md)(…) | Raises the change even |

## See Also

* **Source:** *[IFileWatcher.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Web/Common/IFileWatcher.cs)*