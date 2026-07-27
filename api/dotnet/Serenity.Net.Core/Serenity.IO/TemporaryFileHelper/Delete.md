# TemporaryFileHelper.Delete method (1 of 2)
**namespace:** *[Serenity.IO](../../README.md#serenity.io-namespace)*   **assembly**: *[Serenity.Net.Core](../../README.md)*

Deletes a file.

```csharp
public static void Delete(string filePath, IFileSystem fileSystem = null)
```

| parameter | description |
| --- | --- |
| filePath | File to be deleted (can be null). |
| fileSystem |  |

## See Also

* interface [IFileSystem](../../Serenity/IFileSystem.md)
* class [TemporaryFileHelper](../TemporaryFileHelper.md)

---

# TemporaryFileHelper.Delete method (2 of 2)
**namespace:** *[Serenity.IO](../../README.md#serenity.io-namespace)*   **assembly**: *[Serenity.Net.Core](../../README.md)*

Deletes, tries to delete or marks a file for deletion depending on type.

```csharp
public static void Delete(string filePath, DeleteType type, ITemporaryFileSystem fileSystem = null)
```

| parameter | description |
| --- | --- |
| filePath | File to be deleted (can be null). |
| type | Delete type. |
| fileSystem | File system |

## See Also

* enum [DeleteType](../DeleteType.md)
* interface [ITemporaryFileSystem](../../Serenity/ITemporaryFileSystem.md)
* class [TemporaryFileHelper](../TemporaryFileHelper.md)