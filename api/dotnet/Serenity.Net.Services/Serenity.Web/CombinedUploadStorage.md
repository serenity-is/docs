# CombinedUploadStorage class
**namespace:** *[Serenity.Web](../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

A combined upload storage implementation that uses two upload storage instances, while serving one of them from a sub path like "/temporary/"

```csharp
public class CombinedUploadStorage : IUploadStorage
```

## Public Members

| name | description |
| --- | --- |
| [CombinedUploadStorage](CombinedUploadStorage/CombinedUploadStorage.md)(…) | Creates a new instance of the class |
| [ArchiveFile](CombinedUploadStorage/ArchiveFile.md)(…) |  |
| [CopyFrom](CombinedUploadStorage/CopyFrom.md)(…) |  |
| [DeleteFile](CombinedUploadStorage/DeleteFile.md)(…) |  |
| [FileExists](CombinedUploadStorage/FileExists.md)(…) |  |
| [GetFileMetadata](CombinedUploadStorage/GetFileMetadata.md)(…) |  |
| [GetFiles](CombinedUploadStorage/GetFiles.md)(…) |  |
| [GetFileSize](CombinedUploadStorage/GetFileSize.md)(…) |  |
| [GetFileUrl](CombinedUploadStorage/GetFileUrl.md)(…) |  |
| [OpenFile](CombinedUploadStorage/OpenFile.md)(…) |  |
| [PurgeTemporaryFiles](CombinedUploadStorage/PurgeTemporaryFiles.md)() |  |
| [SetFileMetadata](CombinedUploadStorage/SetFileMetadata.md)(…) |  |
| [WriteFile](CombinedUploadStorage/WriteFile.md)(…) |  |

## Protected Members

| name | description |
| --- | --- |
| [IsSubPath](CombinedUploadStorage/IsSubPath.md)(…) | Returns true if the path is the subpath |
| [UnderSubPath](CombinedUploadStorage/UnderSubPath.md)(…) | Returns if the path is under sub path |

## See Also

* interface [IUploadStorage](IUploadStorage.md)
* **Source:** *[CombinedUploadStorage.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Services/Upload/CombinedUploadStorage.cs)*