# IDiskUploadFileSystem.PurgeDirectory method
**namespace:** *[Serenity.Web](../../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Purges target directory, cleaning temporary files

```csharp
public void PurgeDirectory(string directoryToClean, TimeSpan? autoExpireTime = default(TimeSpan?), 
    int? maxFilesInDirectory = null, string checkFileName = null)
```

| parameter | description |
| --- | --- |
| directoryToClean | Directory to clean |
| autoExpireTime | Auto expire old files timespan |
| maxFilesInDirectory | Max files to keep in directory |
| checkFileName | A filename to check existance to confirm the target is a temporary directory. By default it is ".temporary" |

## See Also

* interface [IDiskUploadFileSystem](../IDiskUploadFileSystem.md)