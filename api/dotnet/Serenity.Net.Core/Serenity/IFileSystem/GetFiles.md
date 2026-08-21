# IFileSystem.GetFiles method
**namespace:** *[Serenity](../../README.md#serenity-namespace)*   **assembly**: *[Serenity.Net.Core](../../README.md)*

Gets the files at the specified path.

```csharp
public string[] GetFiles(string path, string searchPattern = "*", bool recursive = false)
```

| parameter | description |
| --- | --- |
| path | The path of the directory to list. |
| searchPattern | The search pattern used to filter file names. |
| recursive | `true` to scan subdirectories recursively. |

## Return Value

An array of file paths.

## See Also

* interface [IFileSystem](../IFileSystem.md)