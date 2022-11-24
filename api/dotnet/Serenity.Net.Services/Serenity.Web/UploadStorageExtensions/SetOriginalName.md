# UploadStorageExtensions.SetOriginalName method
**namespace:** *[Serenity.Web](../../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Sets original name for a file

```csharp
public static void SetOriginalName(this IUploadStorage uploadStorage, string path, 
    string originalName)
```

| parameter | description |
| --- | --- |
| uploadStorage | Upload storage |
| path | File path |
| originalName | Original name |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | Upload storage is null |

## See Also

* interface [IUploadStorage](../IUploadStorage.md)
* class [UploadStorageExtensions](../UploadStorageExtensions.md)