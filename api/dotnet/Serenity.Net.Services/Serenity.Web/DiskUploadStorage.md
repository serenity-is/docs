# DiskUploadStorage class
**namespace:** *[Serenity.Web](../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

```csharp
public class DiskUploadStorage : IUploadStorage
```

## Public Members

| name | description |
| --- | --- |
| [DiskUploadStorage](DiskUploadStorage/DiskUploadStorage.md)(…) |  |
| [RootPath](DiskUploadStorage/RootPath.md) { get; } |  |
| [RootUrl](DiskUploadStorage/RootUrl.md) { get; } |  |
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
| readonly [fileSystem-](DiskUploadStorage/fileSystem-.md) |  |
| [FilePath](DiskUploadStorage/FilePath.md)(…) |  |

## See Also

* interface [IUploadStorage](IUploadStorage.md)
* **Source:** *[DiskUploadStorage.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Services/Upload/DiskUploadStorage.cs)*