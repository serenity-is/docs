# ClamAVUploadScanner.Scan method
**namespace:** *[Serenity.Extensions](../../README.md#serenity.extensions-namespace)*   **assembly**: *[Serenity.Extensions](../../README.md)*

Processes a temporary upload stream, usually from the HTTP request files and returns false

```csharp
public void Scan(Stream stream, string filename)
```

| parameter | description |
| --- | --- |
| stream | File content stream (usually from HTTP request files) |
| filename | The filename of the uploaded file (original name) |

## See Also

* class [ClamAVUploadScanner](../ClamAVUploadScanner.md)