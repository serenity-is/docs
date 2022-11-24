# UploadStorageExtensions.ReadAllFileBytes method
**namespace:** *[Serenity.Web](../../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Reads all file bytes

```csharp
public static byte[] ReadAllFileBytes(this IUploadStorage uploadStorage, string path)
```

| parameter | description |
| --- | --- |
| uploadStorage | Upload storage |
| path | File path |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | Upload storage is null |

## See Also

* interface [IUploadStorage](../IUploadStorage.md)
* class [UploadStorageExtensions](../UploadStorageExtensions.md)