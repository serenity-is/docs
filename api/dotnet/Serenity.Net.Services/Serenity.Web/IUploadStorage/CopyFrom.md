# IUploadStorage.CopyFrom method
**namespace:** *[Serenity.Web](../../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Copies a file from another upload storage and returns the resulting file path

```csharp
public string CopyFrom(IUploadStorage sourceStorage, string sourcePath, string targetPath, 
    OverwriteOption overwrite)
```

| parameter | description |
| --- | --- |
| sourceStorage | Source upload storage |
| sourcePath | Source file path |
| targetPath | Target file path |
| overwrite | Overwrite option |

## See Also

* enum [OverwriteOption](../OverwriteOption.md)
* interface [IUploadStorage](../IUploadStorage.md)