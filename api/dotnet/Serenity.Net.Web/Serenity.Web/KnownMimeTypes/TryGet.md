# KnownMimeTypes.TryGet method
**namespace:** *[Serenity.Web](../../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Net.Web](../../README.md)*

Gets the MIME type for a given file.

```csharp
public static string TryGet(string path)
```

| parameter | description |
| --- | --- |
| path | The file name whose MIME type will be determined. Only its extension part will be used. |

## Return Value

The determined mime type for the given file, or `null` if unknown.

## See Also

* class [KnownMimeTypes](../KnownMimeTypes.md)