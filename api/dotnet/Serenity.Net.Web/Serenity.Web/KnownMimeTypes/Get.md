# KnownMimeTypes.Get method
**namespace:** *[Serenity.Web](../../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Net.Web](../../README.md)*

Gets the MIME type for a given file using information in the Win32 HKEY_CLASSES_ROOT registry key.

```csharp
public static string Get(string path)
```

| parameter | description |
| --- | --- |
| path | The file name whose MIME type will be determined. Only its extension part will be used. |

## Return Value

The determined mime type for the given file, or `application/octet-stream` otherwise.

## See Also

* class [KnownMimeTypes](../KnownMimeTypes.md)