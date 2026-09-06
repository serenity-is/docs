# UploadPathHelper.FindAvailableName method

Finds an available name for a file.

```csharp
public static string FindAvailableName(string path, Func<string, bool> exists)
```

| parameter | description |
| --- | --- |
| path | File path |
| exists | Function that returns if a file exists |

## Return Value

The available file name.

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | *path* or *exists* is `null`. |

## See Also

* class [UploadPathHelper](../UploadPathHelper.md)