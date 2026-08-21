# FileSystemExtensions.Copy method
**namespace:** *[Serenity](../../README.md#serenity-namespace)*   **assembly**: *[Serenity.Net.Core](../../README.md)*

Copies a file to another destination, optionally overwriting the destination if it exists.

```csharp
public static void Copy(this IFileSystem fileSystem, string sourceFileName, string destFileName, 
    bool overwrite)
```

| parameter | description |
| --- | --- |
| fileSystem | The file system. |
| sourceFileName | The source file name. |
| destFileName | The destination file name. |
| overwrite | `true` to overwrite the destination file if it already exists. |

## See Also

* interface [IFileSystem](../IFileSystem.md)
* class [FileSystemExtensions](../FileSystemExtensions.md)