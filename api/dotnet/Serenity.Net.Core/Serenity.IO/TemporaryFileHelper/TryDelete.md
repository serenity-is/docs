# TemporaryFileHelper.TryDelete method
**namespace:** *[Serenity.IO](../../README.md#serenity.io-namespace)*   **assembly**: *[Serenity.Net.Core](../../README.md)*

Tries to delete the file at the given path, ignoring any errors.

```csharp
public static void TryDelete(string filePath, IFileSystem fileSystem = null)
```

| parameter | description |
| --- | --- |
| filePath | The file to be deleted (can be `null`). |
| fileSystem | The file system to use, or `null` to use the physical file system. |

## See Also

* interface [IFileSystem](../../Serenity/IFileSystem.md)
* class [TemporaryFileHelper](../TemporaryFileHelper.md)