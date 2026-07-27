# TemporaryFileHelper.TryDeleteOrMark method
**namespace:** *[Serenity.IO](../../README.md#serenity.io-namespace)*   **assembly**: *[Serenity.Net.Core](../../README.md)*

Tries to delete a file or marks it for deletion by DeleteMarkedFiles method by creating a ".delete" file.

```csharp
public static void TryDeleteOrMark(string filePath, ITemporaryFileSystem fileSystem = null)
```

| parameter | description |
| --- | --- |
| filePath | File to be deleted |
| fileSystem | File system |

## See Also

* interface [ITemporaryFileSystem](../../Serenity/ITemporaryFileSystem.md)
* class [TemporaryFileHelper](../TemporaryFileHelper.md)