# UploadPathHelper.TryParseThumbSuffix method
**namespace:** *[Serenity.Web](../../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Tries to parse a thumbnail filename suffix, e.g. it ends with "_t.jpg", or "_tNxN.jpg" where N is a number

```csharp
public static bool TryParseThumbSuffix(string path, out string baseName, out string suffix, 
    out int width, out int height)
```

| parameter | description |
| --- | --- |
| path | File path, e.g. some/file_t.jpg |
| baseName | Base name of the file, e.g. some/file. May include folder |
| suffix | Thumb suffix |
| width | Thumb width |
| height | Thumb height |

## See Also

* class [UploadPathHelper](../UploadPathHelper.md)