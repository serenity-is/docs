# DefaultUploadProcessor constructor

Default implementation for [`IUploadProcessor`](../IUploadProcessor.md).

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
| ArgumentNullException | *imageProcessor*, *uploadStorage* or *uploadValidator* is `null`. |

## Remarks

Initializes a new instance of the class.

## See Also

* interface [IImageProcessor](../IImageProcessor.md)
* interface [IUploadStorage](../IUploadStorage.md)
* interface [IUploadValidator](../IUploadValidator.md)
* interface [IUploadAVScanner](../IUploadAVScanner.md)
* class [DefaultUploadProcessor](../DefaultUploadProcessor.md)