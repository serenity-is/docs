# TemporaryFileHelper.PurgeDirectoryDefault method

Clears a folder based on the default conditions.

```csharp
public static void PurgeDirectoryDefault(string directoryToClean, 
    ITemporaryFileSystem? fileSystem = null)
```

| parameter | description |
| --- | --- |
| directoryToClean | The folder to be cleared. |
| fileSystem | The file system to use, or `null` to use the physical file system. |

## Remarks

If any errors occur during cleanup, they are ignored and do not raise an exception. Other errors might raise an exception. As errors are ignored, this method cannot guarantee that fewer than the specified number of files will remain in the folder after it ends.

## See Also

* interface [ITemporaryFileSystem](../../Serenity/ITemporaryFileSystem.md)
* class [TemporaryFileHelper](../TemporaryFileHelper.md)