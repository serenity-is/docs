# TemporaryFileHelper.PurgeDirectoryDefault method
**namespace:** *[Serenity.IO](../../README.md#serenity.io-namespace)*   **assembly**: *[Serenity.Net.Core](../../README.md)*

Clears a folder based on default conditions

```csharp
public static void PurgeDirectoryDefault(string directoryToClean)
```

| parameter | description |
| --- | --- |
| directoryToClean | Folder to be cleared |

## Remarks

If any errors occur during cleanup, this doesn't raise an exception and ignored. Other errors might raise an exception. As errors are ignored, method can't guarantee that less than specified number of files will be in the folder after it ends.

## See Also

* class [TemporaryFileHelper](../TemporaryFileHelper.md)