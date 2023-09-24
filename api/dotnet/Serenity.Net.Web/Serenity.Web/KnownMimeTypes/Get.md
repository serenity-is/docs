# KnownMimeTypes.Get method
**namespace:** *[Serenity.Web](../../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Net.Web](../../README.md)*

Gets MIME type for a given file using information in Win32 HKEY_CLASSES_ROOT registry key.

```csharp
public static string Get(string path)
```

| parameter | description |
| --- | --- |
| path | File name whose MIME type will be determined. Its only extension part will be used. |

## Return Value

Determined mime type for given file. "application/octet-stream" otherwise.

## See Also

* class [KnownMimeTypes](../KnownMimeTypes.md)