# FileSystemExtensions class
**namespace:** *[Serenity](../README.md#serenity-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

IFileSystem extensions to reduce dependency on System.IO, in case these methods are also added to IFileSystem in the future

```csharp
public static class FileSystemExtensions
```

## Public Members

| name | description |
| --- | --- |
| static [ChangeExtension](FileSystemExtensions/ChangeExtension.md)(…) | Changes the extension of a path string. |
| static [Combine](FileSystemExtensions/Combine.md)(…) | Combines path strings (3 methods) |
| static [Copy](FileSystemExtensions/Copy.md)(…) | Copies a file to another destination by optionally overwriting the destination if it exists |
| static [GetDirectoryName](FileSystemExtensions/GetDirectoryName.md)(…) | Gets directory name for path |
| static [GetExtension](FileSystemExtensions/GetExtension.md)(…) | Gets extension for path |
| static [GetFileName](FileSystemExtensions/GetFileName.md)(…) | Gets file name for path |
| static [GetFileNameWithoutExtension](FileSystemExtensions/GetFileNameWithoutExtension.md)(…) | Gets file name without extension for path |
| static [IsPathRooted](FileSystemExtensions/IsPathRooted.md)(…) | Gets if the path is rooted |

## See Also

* **Source:** *[FileSystemExtensions.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Core/IO/FileSystemExtensions.cs)*