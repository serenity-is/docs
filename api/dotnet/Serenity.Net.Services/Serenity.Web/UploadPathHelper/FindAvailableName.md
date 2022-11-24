# UploadPathHelper.FindAvailableName method
**namespace:** *[Serenity.Web](../../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Finds an available name for a file

```csharp
public static string FindAvailableName(string path, Func<string, bool> exists)
```

| parameter | description |
| --- | --- |
| path | File path |
| exists | Function that returns if a file exists |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | Path or exists is null |

## See Also

* class [UploadPathHelper](../UploadPathHelper.md)