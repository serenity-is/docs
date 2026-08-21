# DiskUploadStorage constructor
**namespace:** *[Serenity.Web](../../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Initializes a new instance of the class.

```csharp
public DiskUploadStorage(DiskUploadStorageOptions options, IDiskUploadFileSystem fileSystem = null)
```

| parameter | description |
| --- | --- |
| options | Upload options |
| fileSystem | File system to use |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | *options* is `null`. |

## See Also

* class [DiskUploadStorageOptions](../DiskUploadStorageOptions.md)
* interface [IDiskUploadFileSystem](../IDiskUploadFileSystem.md)
* class [DiskUploadStorage](../DiskUploadStorage.md)