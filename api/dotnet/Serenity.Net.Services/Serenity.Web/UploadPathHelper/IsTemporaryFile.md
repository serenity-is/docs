# UploadPathHelper.IsTemporaryFile method
**namespace:** *[Serenity.Web](../../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Determines whether the specified file name represents a temporary upload file.

```csharp
public static bool IsTemporaryFile(string fileName)
```

| parameter | description |
| --- | --- |
| fileName | The name of the file to evaluate. Can be null or empty. |

## Return Value

true if the file name is not null or empty and indicates a temporary upload file; otherwise, false.

## See Also

* class [UploadPathHelper](../UploadPathHelper.md)