# TemporaryFileHelper.PurgeDirectory method
**namespace:** *[Serenity.IO](../../README.md#serenity.io-namespace)*   **assembly**: *[Serenity.Net.Core](../../README.md)*

Clears a folder based on specified conditions

```csharp
public static void PurgeDirectory(string directoryToClean, TimeSpan autoExpireTime, 
    int maxFilesInDirectory, string checkFileName)
```

| parameter | description |
| --- | --- |
| directoryToClean | Folder to be cleared |
| autoExpireTime | Files with creation time older than this is deleted. If passed as 0, time based cleanup is skipped. |
| maxFilesInDirectory | If more than this number of files exists, files will be deleted starting from oldest to newest. By passing 0, all files can be deleted. If passed as -1, file count based cleanup is skipped. |
| checkFileName | Safety file to be checked. If it is specified and it doesn't exists, operation is aborted. |

## Remarks

If any errors occur during cleanup, this doesn't raise an exception and ignored. Other errors might raise an exception. As errors are ignored, method can't gurantee that less than specified number of files will be in the folder after it ends.

## See Also

* class [TemporaryFileHelper](../TemporaryFileHelper.md)