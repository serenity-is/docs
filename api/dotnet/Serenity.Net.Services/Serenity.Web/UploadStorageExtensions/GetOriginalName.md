# UploadStorageExtensions.GetOriginalName method
**namespace:** *[Serenity.Web](../../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Gets original name of a file

```csharp
public static string GetOriginalName(this IUploadStorage uploadStorage, string path)
```

| parameter | description |
| --- | --- |
| uploadStorage | Upload storage |
| path | File path |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | uploadStorage is null |

## See Also

* interface [IUploadStorage](../IUploadStorage.md)
* class [UploadStorageExtensions](../UploadStorageExtensions.md)