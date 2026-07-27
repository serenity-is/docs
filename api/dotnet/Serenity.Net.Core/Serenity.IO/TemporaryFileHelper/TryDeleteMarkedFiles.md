# TemporaryFileHelper.TryDeleteMarkedFiles method
**namespace:** *[Serenity.IO](../../README.md#serenity.io-namespace)*   **assembly**: *[Serenity.Net.Core](../../README.md)*

Tries to delete all files that is marked for deletion by TryDeleteOrMark in a folder.

```csharp
public static void TryDeleteMarkedFiles(string path, ITemporaryFileSystem fileSystem = null)
```

| parameter | description |
| --- | --- |
| path | Path of marked files to be deleted |
| fileSystem | File system |

## See Also

* interface [ITemporaryFileSystem](../../Serenity/ITemporaryFileSystem.md)
* class [TemporaryFileHelper](../TemporaryFileHelper.md)