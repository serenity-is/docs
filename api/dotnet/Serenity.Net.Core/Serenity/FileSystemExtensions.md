# FileSystemExtensions class
**namespace:** *[Serenity](../README.md#serenity-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Provides extension methods for [`IFileSystem`](IFileSystem.md) that delegate to Path helpers, reducing direct dependency on System.IO in case these methods are later added to [`IFileSystem`](IFileSystem.md).

```csharp
public static class FileSystemExtensions
```

## Public Members

| name | description |
| --- | --- |
| static [ChangeExtension](FileSystemExtensions/ChangeExtension.md)(…) | Changes the extension of a path string. |
| static [Combine](FileSystemExtensions/Combine.md)(…) | Combines two path strings. (3 methods) |
| static [Copy](FileSystemExtensions/Copy.md)(…) | Copies a file to another destination, optionally overwriting the destination if it exists. |
| static [GetDirectoryName](FileSystemExtensions/GetDirectoryName.md)(…) | Gets the directory name for the specified path. |
| static [GetExtension](FileSystemExtensions/GetExtension.md)(…) | Gets the extension for the specified path. |
| static [GetFileName](FileSystemExtensions/GetFileName.md)(…) | Gets the file name for the specified path. |
| static [GetFileNameWithoutExtension](FileSystemExtensions/GetFileNameWithoutExtension.md)(…) | Gets the file name without its extension for the specified path. |
| static [IsPathRooted](FileSystemExtensions/IsPathRooted.md)(…) | Gets a value indicating whether the specified path is rooted. |

## See Also

* **Source:** *[FileSystemExtensions.cs](https://github.com/serenity-is/Serenity/blob/a5013fdf777dbbd87589205ddffcb67f18bea673/src/core/IO/FileSystemExtensions.cs)*