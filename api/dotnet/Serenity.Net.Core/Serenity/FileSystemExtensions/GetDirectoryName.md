# FileSystemExtensions.GetDirectoryName method
**namespace:** *[Serenity](../../README.md#serenity-namespace)*   **assembly**: *[Serenity.Net.Core](../../README.md)*

Gets the directory name for the specified path.

```csharp
public static string GetDirectoryName(this IFileSystem _, string path)
```

| parameter | description |
| --- | --- |
| _ | The file system. |
| path | The path. |

## Return Value

The directory name, or `null` if the path does not contain a directory.

## See Also

* interface [IFileSystem](../IFileSystem.md)
* class [FileSystemExtensions](../FileSystemExtensions.md)