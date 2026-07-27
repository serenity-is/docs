# FilesToDelete class
**namespace:** *[Serenity.Web](../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

A container that stores list of file paths to delete (old files) if the upload related operation is successful. If it is not, the old files will be kept while the new files will be deleted.

```csharp
public class FilesToDelete : List<string>, IDisposable, IFilesToDelete
```

| parameter | description |
| --- | --- |
| storage | Upload storage |

## Public Members

| name | description |
| --- | --- |
| [FilesToDelete](FilesToDelete/FilesToDelete.md)(…) | A container that stores list of file paths to delete (old files) if the upload related operation is successful. If it is not, the old files will be kept while the new files will be deleted. |
| [Dispose](FilesToDelete/Dispose.md)() | Deletes the new files if [`KeepNewFiles`](FilesToDelete/KeepNewFiles.md) is not called. |
| [KeepNewFiles](FilesToDelete/KeepNewFiles.md)() | Keeps new files, while removing old files |
| [RegisterNewFile](FilesToDelete/RegisterNewFile.md)(…) | Registers a new file |
| [RegisterOldFile](FilesToDelete/RegisterOldFile.md)(…) | Registers an old file |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | storage is null |

## Remarks

Creates a new instance of the class

## See Also

* interface [IFilesToDelete](IFilesToDelete.md)
* **Source:** *[FilesToDelete.cs](https://github.com/serenity-is/Serenity/blob/master/src/Services/Upload/FilesToDelete.cs)*