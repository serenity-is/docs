# IFileSystem interface
**namespace:** *[Serenity](../README.md#serenity-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Base file system for abstracting physical disk access

```csharp
public interface IFileSystem
```

## Members

| name | description |
| --- | --- |
| [CreateDirectory](IFileSystem/CreateDirectory.md)(…) | Creates a directory |
| [CreateFile](IFileSystem/CreateFile.md)(…) | Creates a file for writing or optionally overwrites if exists |
| [DeleteDirectory](IFileSystem/DeleteDirectory.md)(…) | Deletes the directory at path |
| [DeleteFile](IFileSystem/DeleteFile.md)(…) | Deletes the file at path |
| [DirectoryExists](IFileSystem/DirectoryExists.md)(…) | Checks if directory exists |
| [FileExists](IFileSystem/FileExists.md)(…) | Checks if file exists |
| [GetDirectories](IFileSystem/GetDirectories.md)(…) | Gets directories at specified path |
| [GetFiles](IFileSystem/GetFiles.md)(…) | Gets files at specified path |
| [GetFileSize](IFileSystem/GetFileSize.md)(…) | Gets file size for specified path |
| [GetFullPath](IFileSystem/GetFullPath.md)(…) | Returns the absolute path for the specified path string. |
| [GetRelativePath](IFileSystem/GetRelativePath.md)(…) | Returns the absolute path for the specified path string. |
| [OpenRead](IFileSystem/OpenRead.md)(…) | Opens the file at path for reading |
| [ReadAllBytes](IFileSystem/ReadAllBytes.md)(…) | Reads all bytes from a file |
| [ReadAllText](IFileSystem/ReadAllText.md)(…) | Reads all text from a file |
| [WriteAllBytes](IFileSystem/WriteAllBytes.md)(…) | Writes all bytes to a file |
| [WriteAllText](IFileSystem/WriteAllText.md)(…) | Writes content to a file |

## See Also

* **Source:** *[IFileSystem.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Core/IO/IFileSystem.cs)*