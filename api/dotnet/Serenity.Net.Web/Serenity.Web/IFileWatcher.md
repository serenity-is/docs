# IFileWatcher interface
**namespace:** *[Serenity.Web](../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Net.Web](../README.md)*

Abstraction for a file system watcher.

```csharp
public interface IFileWatcher
```

## Members

| name | description |
| --- | --- |
| [Filter](IFileWatcher/Filter.md) { get; } | Gets the file filter being watched. |
| [Path](IFileWatcher/Path.md) { get; } | Gets the directory path being watched. |
| event [Changed](IFileWatcher/Changed.md) | Raised when a watched file changes. |
| [RaiseChanged](IFileWatcher/RaiseChanged.md)(…) | Raises the [`Changed`](IFileWatcher/Changed.md) event for the specified file. |

## See Also

* **Source:** *[IFileWatcher.cs](https://github.com/serenity-is/Serenity/blob/master/src/Web/Common/IFileWatcher.cs)*