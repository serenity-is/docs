# TemporaryFileHelper.TryDeleteOrMark method
**namespace:** *[Serenity.IO](../../README.md#serenity.io-namespace)*   **assembly**: *[Serenity.Net.Core](../../README.md)*

Tries to delete a file, or marks it for deletion by [`TryDeleteMarkedFiles`](TryDeleteMarkedFiles.md) by creating a ".delete" file.

```csharp
public static void TryDeleteOrMark(string filePath, ITemporaryFileSystem fileSystem = null)
```

| parameter | description |
| --- | --- |
| filePath | The file to be deleted. |
| fileSystem | The file system to use, or `null` to use the physical file system. |

## See Also

* interface [ITemporaryFileSystem](../../Serenity/ITemporaryFileSystem.md)
* class [TemporaryFileHelper](../TemporaryFileHelper.md)