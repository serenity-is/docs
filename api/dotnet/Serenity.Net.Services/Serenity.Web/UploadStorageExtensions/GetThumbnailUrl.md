# UploadStorageExtensions.GetThumbnailUrl method

Gets thumbnail URL for the file path.

```csharp
public static string GetThumbnailUrl(this IUploadStorage uploadStorage, string path)
```

| parameter | description |
| --- | --- |
| uploadStorage | Upload storage |
| path | Path |

## Return Value

The thumbnail URL, or `null` if the path is empty.

## See Also

* interface [IUploadStorage](../IUploadStorage.md)
* class [UploadStorageExtensions](../UploadStorageExtensions.md)