# FilesToDelete constructor
**namespace:** *[Serenity.Web](../../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

A container that stores list of file paths to delete (old files) if the upload related operation is successful. If it is not, the old files will be kept while the new files will be deleted.

```csharp
public FilesToDelete(IUploadStorage storage)
```

| parameter | description |
| --- | --- |
| storage | Upload storage |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | storage is null |

## Remarks

Creates a new instance of the class

## See Also

* interface [IUploadStorage](../IUploadStorage.md)
* class [FilesToDelete](../FilesToDelete.md)