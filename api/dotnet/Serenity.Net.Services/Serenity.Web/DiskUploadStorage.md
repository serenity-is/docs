# DiskUploadStorage class
**namespace:** *[Serenity.Web](../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

A file system based upload storage implementation

```csharp
public class DiskUploadStorage : IUploadStorage
```

## Public Members

| name | description |
| --- | --- |
| [DiskUploadStorage](DiskUploadStorage/DiskUploadStorage.md)(…) | Creates a new instance of the class |
| [RootPath](DiskUploadStorage/RootPath.md) { get; } | Root path for the uploads |
| [RootUrl](DiskUploadStorage/RootUrl.md) { get; } | Root URL for the uploads |
| [ArchiveFile](DiskUploadStorage/ArchiveFile.md)(…) |  |
| [CopyFrom](DiskUploadStorage/CopyFrom.md)(…) |  |
| [DeleteFile](DiskUploadStorage/DeleteFile.md)(…) |  |
| [FileExists](DiskUploadStorage/FileExists.md)(…) |  |
| virtual [GetFileMetadata](DiskUploadStorage/GetFileMetadata.md)(…) |  |
| [GetFiles](DiskUploadStorage/GetFiles.md)(…) |  |
| [GetFileSize](DiskUploadStorage/GetFileSize.md)(…) |  |
| [GetFileUrl](DiskUploadStorage/GetFileUrl.md)(…) |  |
| [OpenFile](DiskUploadStorage/OpenFile.md)(…) |  |
| virtual [PurgeTemporaryFiles](DiskUploadStorage/PurgeTemporaryFiles.md)() |  |
| virtual [SetFileMetadata](DiskUploadStorage/SetFileMetadata.md)(…) |  |
| [WriteFile](DiskUploadStorage/WriteFile.md)(…) |  |

## Protected Members

| name | description |
| --- | --- |
| readonly [fileSystem-](DiskUploadStorage/fileSystem-.md) | File system |
| [FilePath](DiskUploadStorage/FilePath.md)(…) | Gets the full path for the file |

## See Also

* interface [IUploadStorage](IUploadStorage.md)
* **Source:** *[DiskUploadStorage.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Services/Upload/DiskUploadStorage.cs)*