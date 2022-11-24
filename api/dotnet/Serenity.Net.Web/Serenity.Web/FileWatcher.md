# FileWatcher class
**namespace:** *[Serenity.Web](../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Net.Web](../README.md)*

Default file watcher implementation for physical file system

```csharp
public class FileWatcher : IDisposable, IFileWatcher
```

## Public Members

| name | description |
| --- | --- |
| [FileWatcher](FileWatcher/FileWatcher.md)(…) | Creates a new instance of the class |
| [Filter](FileWatcher/Filter.md) { get; } |  |
| [Path](FileWatcher/Path.md) { get; } |  |
| event [Changed](FileWatcher/Changed.md) |  |
| [RaiseChanged](FileWatcher/RaiseChanged.md)(…) |  |

## Protected Members

| name | description |
| --- | --- |
| [Dispose](FileWatcher/Dispose.md)(…) |  |

## See Also

* interface [IFileWatcher](IFileWatcher.md)
* **Source:** *[FileWatcher.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Web/Common/FileWatcher.cs)*