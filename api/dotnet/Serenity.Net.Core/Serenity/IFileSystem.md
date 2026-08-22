# IFileSystem interface
**namespace:** *[Serenity](../README.md#serenity-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Base file system abstraction for accessing the physical disk, allowing file and directory operations to be mocked or replaced.

```csharp
public interface IFileSystem
```

## Members

| name | description |
| --- | --- |
| [CreateDirectory](IFileSystem/CreateDirectory.md)(…) | Creates a directory. |
| [CreateFile](IFileSystem/CreateFile.md)(…) | Creates a file for writing, optionally overwriting it if it already exists. |
| [DeleteDirectory](IFileSystem/DeleteDirectory.md)(…) | Deletes the directory at the specified path. |
| [DeleteFile](IFileSystem/DeleteFile.md)(…) | Deletes the file at the specified path. |
| [DirectoryExists](IFileSystem/DirectoryExists.md)(…) | Checks whether a directory exists at the specified path. |
| [FileExists](IFileSystem/FileExists.md)(…) | Checks whether a file exists at the specified path. |
| [GetDirectories](IFileSystem/GetDirectories.md)(…) | Gets the directories at the specified path. |
| [GetFiles](IFileSystem/GetFiles.md)(…) | Gets the files at the specified path. |
| [GetFileSize](IFileSystem/GetFileSize.md)(…) | Gets the size of the file at the specified path. |
| [GetFullPath](IFileSystem/GetFullPath.md)(…) | Returns the absolute path for the specified path string. |
| [GetLastWriteTimeUtc](IFileSystem/GetLastWriteTimeUtc.md)(…) | Gets the last write time in UTC for the file at the specified path. |
| [GetRelativePath](IFileSystem/GetRelativePath.md)(…) | Returns a relative path from one path to another. |
| [OpenRead](IFileSystem/OpenRead.md)(…) | Opens the file at the specified path for reading. |
| [ReadAllBytes](IFileSystem/ReadAllBytes.md)(…) | Reads all bytes from the file at the specified path. |
| [ReadAllText](IFileSystem/ReadAllText.md)(…) | Reads all text from the file at the specified path. |
| [WriteAllBytes](IFileSystem/WriteAllBytes.md)(…) | Writes all bytes to the file at the specified path. |
| [WriteAllText](IFileSystem/WriteAllText.md)(…) | Writes content to the file at the specified path. |

## See Also

* **Source:** *[IFileSystem.cs](https://github.com/serenity-is/Serenity/blob/a5013fdf777dbbd87589205ddffcb67f18bea673/src/core/IO/IFileSystem.cs)*