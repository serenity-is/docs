# IUploadStorage.SetFileMetadata method
**namespace:** *[Serenity.Web](../../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Sets file metadata for a file

```csharp
public void SetFileMetadata(string path, IDictionary<string, string> metadata, bool overwriteAll)
```

| parameter | description |
| --- | --- |
| path | File path |
| metadata | Metadata dictionary |
| overwriteAll | True to override any existing metadata for file, false to merge existing metadata by their key. |

## See Also

* interface [IUploadStorage](../IUploadStorage.md)