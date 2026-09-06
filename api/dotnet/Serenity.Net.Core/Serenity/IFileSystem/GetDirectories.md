# IFileSystem.GetDirectories method

Gets the directories at the specified path.

```csharp
public string[] GetDirectories(string path, string searchPattern = "*", bool recursive = false)
```

| parameter | description |
| --- | --- |
| path | The path of the directory to list. |
| searchPattern | The search pattern used to filter directory names. |
| recursive | `true` to scan subdirectories recursively. |

## Return Value

An array of directory paths.

## See Also

* interface [IFileSystem](../IFileSystem.md)