# DefaultUploadProcessor constructor
**namespace:** *[Serenity.Web](../../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Creates a new instance of the class

```csharp
public DefaultUploadProcessor(IImageProcessor imageProcessor, IUploadStorage uploadStorage, 
    IUploadValidator uploadValidator, ILogger<DefaultUploadProcessor> logger = null, 
    IUploadAVScanner avScanner = null)
```

| parameter | description |
| --- | --- |
| imageProcessor | Image processor |
| uploadStorage | Upload storage |
| uploadValidator | Upload validator |
| logger | Logger |
| avScanner | Optional antivirus scanner |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException |  |

## See Also

* interface [IImageProcessor](../IImageProcessor.md)
* interface [IUploadStorage](../IUploadStorage.md)
* interface [IUploadValidator](../IUploadValidator.md)
* interface [IUploadAVScanner](../IUploadAVScanner.md)
* class [DefaultUploadProcessor](../DefaultUploadProcessor.md)