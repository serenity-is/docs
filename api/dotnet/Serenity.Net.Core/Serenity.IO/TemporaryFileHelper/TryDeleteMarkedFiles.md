# TemporaryFileHelper.TryDeleteMarkedFiles method

Tries to delete all files in a folder that were marked for deletion by [`TryDeleteOrMark`](./TryDeleteOrMark.md).

```csharp
public static void TryDeleteMarkedFiles(string path, ITemporaryFileSystem? fileSystem = null)
```

| parameter | description |
| --- | --- |
| path | The path of the marked files to be deleted. |
| fileSystem | The file system to use, or `null` to use the physical file system. |

## See Also

* interface [ITemporaryFileSystem](../../Serenity/ITemporaryFileSystem.md)
* class [TemporaryFileHelper](../TemporaryFileHelper.md)