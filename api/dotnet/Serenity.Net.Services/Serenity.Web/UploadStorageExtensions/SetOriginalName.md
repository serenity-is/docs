# UploadStorageExtensions.SetOriginalName method

Sets original name for a file.

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
| ArgumentNullException | *uploadStorage* is `null`. |

## See Also

* interface [IUploadStorage](../IUploadStorage.md)
* class [UploadStorageExtensions](../UploadStorageExtensions.md)