# UploadStorageExtensions.GetOriginalName method

Gets original name of a file.

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
| ArgumentNullException | *uploadStorage* is `null`. |

## See Also

* interface [IUploadStorage](../IUploadStorage.md)
* class [UploadStorageExtensions](../UploadStorageExtensions.md)