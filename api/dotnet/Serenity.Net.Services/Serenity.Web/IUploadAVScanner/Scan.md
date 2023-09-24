# IUploadAVScanner.Scan method
**namespace:** *[Serenity.Web](../../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Processes a temporary upload stream, usually from the HTTP request files and raises an exception if any issues found or an error occured during scan

```csharp
public void Scan(Stream stream, string filename)
```

| parameter | description |
| --- | --- |
| stream | File content stream (usually from HTTP request files) |
| filename | The filename of the uploaded file (original name) |

## See Also

* interface [IUploadAVScanner](../IUploadAVScanner.md)