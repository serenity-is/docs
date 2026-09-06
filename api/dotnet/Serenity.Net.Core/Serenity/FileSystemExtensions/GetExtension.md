# FileSystemExtensions.GetExtension method

Gets the extension for the specified path.

```csharp
public static string GetExtension(this IFileSystem _, string path)
```

| parameter | description |
| --- | --- |
| _ | The file system. |
| path | The path. |

## Return Value

The extension, including the leading period, or an empty string if there is no extension.

## See Also

* interface [IFileSystem](../IFileSystem.md)
* class [FileSystemExtensions](../FileSystemExtensions.md)