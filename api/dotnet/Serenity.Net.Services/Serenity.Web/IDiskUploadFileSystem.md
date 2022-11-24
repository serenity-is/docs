# IDiskUploadFileSystem interface
**namespace:** *[Serenity.Web](../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Extension for IFileSystem with disk upload storage specific methods.

```csharp
public interface IDiskUploadFileSystem : IFileSystem
```

## Members

| name | description |
| --- | --- |
| [Delete](IDiskUploadFileSystem/Delete.md)(…) | Deletes the file with a DeleteType option |
| [PurgeDirectory](IDiskUploadFileSystem/PurgeDirectory.md)(…) | Purges target directory, cleaning temporary files |
| [TryDeleteMarkedFiles](IDiskUploadFileSystem/TryDeleteMarkedFiles.md)(…) | Tries to delete marked files in a directory |
| [TryDeleteOrMark](IDiskUploadFileSystem/TryDeleteOrMark.md)(…) | Tries to delete or marks a file for future deletion |

## See Also

* interface [IFileSystem](../Serenity.Net.Core/../Serenity/IFileSystem.md)