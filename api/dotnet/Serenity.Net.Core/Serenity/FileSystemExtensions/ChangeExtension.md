# FileSystemExtensions.ChangeExtension method
**namespace:** *[Serenity](../../README.md#serenity-namespace)*   **assembly**: *[Serenity.Net.Core](../../README.md)*

Changes the extension of a path string.

```csharp
public static string ChangeExtension(this IFileSystem _, string path, string extension)
```

| parameter | description |
| --- | --- |
| _ | The file system. |
| path | The path information to modify. The path cannot contain any of the characters defined in GetInvalidPathChars. |
| extension | The new extension (with or without a leading period). Specify `null` to remove an existing extension from *path*. |

## Return Value

The modified path.

## See Also

* interface [IFileSystem](../IFileSystem.md)
* class [FileSystemExtensions](../FileSystemExtensions.md)