# DefaultUploadProcessor constructor
**namespace:** *[Serenity.Web](../../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Creates a new instance of the class

```csharp
public DefaultUploadProcessor(IImageProcessor imageProcessor, IUploadStorage uploadStorage, 
    IUploadValidator uploadValidator, IExceptionLogger logger = null)
```

| parameter | description |
| --- | --- |
| imageProcessor | Image processor |
| uploadStorage | Upload storage |
| uploadValidator | Upload validator |
| logger | Exception logger |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException |  |

## See Also

* interface [IImageProcessor](../../global/IImageProcessor.md)
* interface [IUploadStorage](../IUploadStorage.md)
* interface [IUploadValidator](../IUploadValidator.md)
* interface [IExceptionLogger](../Serenity.Net.Core/../../Serenity.Abstractions/IExceptionLogger.md)
* class [DefaultUploadProcessor](../DefaultUploadProcessor.md)