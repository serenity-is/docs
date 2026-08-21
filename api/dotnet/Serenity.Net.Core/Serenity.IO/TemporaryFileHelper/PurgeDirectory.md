# TemporaryFileHelper.PurgeDirectory method
**namespace:** *[Serenity.IO](../../README.md#serenity.io-namespace)*   **assembly**: *[Serenity.Net.Core](../../README.md)*

Clears a folder based on the specified conditions.

```csharp
public static void PurgeDirectory(string directoryToClean, TimeSpan autoExpireTime, 
    int maxFilesInDirectory, string checkFileName, ITemporaryFileSystem fileSystem = null)
```

| parameter | description |
| --- | --- |
| directoryToClean | The folder to be cleared. |
| autoExpireTime | Files with a creation time older than this are deleted. If passed as Zero, time-based cleanup is skipped. |
| maxFilesInDirectory | If more than this number of files exist, files are deleted starting from oldest to newest. Passing `0` deletes all files; passing `-1` skips file-count-based cleanup. |
| checkFileName | The safety file to check. If specified and it does not exist, the operation is aborted. |
| fileSystem | The file system to use, or `null` to use the physical file system. |

## Remarks

If any errors occur during cleanup, they are ignored and do not raise an exception. Other errors might raise an exception. As errors are ignored, this method cannot guarantee that fewer than the specified number of files will remain in the folder after it ends.

## See Also

* interface [ITemporaryFileSystem](../../Serenity/ITemporaryFileSystem.md)
* class [TemporaryFileHelper](../TemporaryFileHelper.md)