# TemporaryFileHelper.Delete method (1 of 2)
**namespace:** *[Serenity.IO](../../README.md#serenity.io-namespace)*   **assembly**: *[Serenity.Net.Core](../../README.md)*

Deletes a file.

```csharp
public static void Delete(string filePath)
```

| parameter | description |
| --- | --- |
| filePath | File to be deleted (can be null). |

## See Also

* class [TemporaryFileHelper](../TemporaryFileHelper.md)

---

# TemporaryFileHelper.Delete method (2 of 2)
**namespace:** *[Serenity.IO](../../README.md#serenity.io-namespace)*   **assembly**: *[Serenity.Net.Core](../../README.md)*

Deletes, tries to delete or marks a file for deletion depending on type.

```csharp
public static void Delete(string filePath, DeleteType type)
```

| parameter | description |
| --- | --- |
| filePath | File to be deleted (can be null). |
| type | Delete type. |

## See Also

* enum [DeleteType](../DeleteType.md)
* class [TemporaryFileHelper](../TemporaryFileHelper.md)