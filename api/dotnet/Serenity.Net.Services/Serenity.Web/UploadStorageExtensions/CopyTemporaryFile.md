# UploadStorageExtensions.CopyTemporaryFile method
**namespace:** *[Serenity.Web](../../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Copies a temporary file to its target location

```csharp
public static CopyTemporaryFileResult CopyTemporaryFile(this IUploadStorage uploadStorage, 
    CopyTemporaryFileOptions options)
```

| parameter | description |
| --- | --- |
| uploadStorage | Upload storage |
| options | Copy options |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | uploadStorage is null |

## See Also

* class [CopyTemporaryFileResult](../CopyTemporaryFileResult.md)
* interface [IUploadStorage](../IUploadStorage.md)
* class [CopyTemporaryFileOptions](../CopyTemporaryFileOptions.md)
* class [UploadStorageExtensions](../UploadStorageExtensions.md)