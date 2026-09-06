# UploadStorageExtensions.ReadAllFileBytes method

Reads all file bytes.

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
| ArgumentNullException | *uploadStorage* is `null`. |

## See Also

* interface [IUploadStorage](../IUploadStorage.md)
* class [UploadStorageExtensions](../UploadStorageExtensions.md)