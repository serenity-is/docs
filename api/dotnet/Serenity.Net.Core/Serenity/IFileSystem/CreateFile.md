# IFileSystem.CreateFile method
**namespace:** *[Serenity](../../README.md#serenity-namespace)*   **assembly**: *[Serenity.Net.Core](../../README.md)*

Creates a file for writing, optionally overwriting it if it already exists.

```csharp
public Stream CreateFile(string path, bool overwrite = true)
```

| parameter | description |
| --- | --- |
| path | The path of the file to create. |
| overwrite | `true` to overwrite the file if it already exists. |

## Return Value

A stream for writing to the created file.

## See Also

* interface [IFileSystem](../IFileSystem.md)