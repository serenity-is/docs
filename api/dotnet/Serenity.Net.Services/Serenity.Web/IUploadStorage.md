# IUploadStorage interface
**namespace:** *[Serenity.Web](../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Abstraction for an upload storage

```csharp
public interface IUploadStorage
```

## Members

| name | description |
| --- | --- |
| [ArchiveFile](IUploadStorage/ArchiveFile.md)(…) | Copies the file to the archive folder |
| [CopyFrom](IUploadStorage/CopyFrom.md)(…) | Copies a file from another upload storage and returns the resulting file path |
| [DeleteFile](IUploadStorage/DeleteFile.md)(…) | Deletes the file at path |
| [FileExists](IUploadStorage/FileExists.md)(…) | Returns if a file at path exists |
| [GetFileMetadata](IUploadStorage/GetFileMetadata.md)(…) | Gets metadata dictionary for a file |
| [GetFiles](IUploadStorage/GetFiles.md)(…) | Gets list of files matching a search pattern |
| [GetFileSize](IUploadStorage/GetFileSize.md)(…) | Gets file size |
| [GetFileUrl](IUploadStorage/GetFileUrl.md)(…) | Gets the URL for a file |
| [OpenFile](IUploadStorage/OpenFile.md)(…) | Opens a file stream. The caller should dispose the stream. |
| [PurgeTemporaryFiles](IUploadStorage/PurgeTemporaryFiles.md)() | Purges temporary files. Only useful for temporary storage. |
| [SetFileMetadata](IUploadStorage/SetFileMetadata.md)(…) | Sets file metadata for a file |
| [WriteFile](IUploadStorage/WriteFile.md)(…) | Writes a file |

## See Also

* **Source:** *[IUploadStorage.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Services/Upload/IUploadStorage.cs)*