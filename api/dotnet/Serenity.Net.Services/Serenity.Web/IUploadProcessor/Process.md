# IUploadProcessor.Process method
**namespace:** *[Serenity.Web](../../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Processes a temporary upload stream, usually from the HTTP request files and returns information about the result

```csharp
public ProcessedUploadInfo Process(Stream fileContent, string filename, IUploadOptions options)
```

| parameter | description |
| --- | --- |
| fileContent | File content stream (usually from HTTP request files) |
| filename | The filename of the uploaded file (original name) |
| options | Upload options to use for validation / thumbnail generation |

## See Also

* class [ProcessedUploadInfo](../ProcessedUploadInfo.md)
* interface [IUploadOptions](../Serenity.Net.Core/../../Serenity.ComponentModel/IUploadOptions.md)
* interface [IUploadProcessor](../IUploadProcessor.md)