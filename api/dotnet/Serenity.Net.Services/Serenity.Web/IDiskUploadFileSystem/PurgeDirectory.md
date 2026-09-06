# IDiskUploadFileSystem.PurgeDirectory method

Purges target directory, cleaning temporary files

```csharp
public void PurgeDirectory(string directoryToClean, TimeSpan? autoExpireTime = default, 
    int? maxFilesInDirectory = null, string checkFileName = null)
```

| parameter | description |
| --- | --- |
| directoryToClean | Directory to clean |
| autoExpireTime | Auto expire old files timespan |
| maxFilesInDirectory | Max files to keep in directory |
| checkFileName | A filename to check existence to confirm the target is a temporary directory. By default it is ".temporary" |

## See Also

* interface [IDiskUploadFileSystem](../IDiskUploadFileSystem.md)