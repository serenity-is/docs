# FileUploadBehavior.CheckUploadedImageAndCreateThumbs method
**namespace:** *[Serenity.Services](../../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Web](../../README.md)*

Checks the uploaded image and creates thumbs if required based on options

```csharp
public static void CheckUploadedImageAndCreateThumbs(IUploadOptions uploadOptions, 
    IUploadValidator validator, IImageProcessor imageProcessor, IUploadStorage storage, 
    ref string temporaryFile)
```

| parameter | description |
| --- | --- |
| uploadOptions | Upload options |
| validator | Upload validator |
| imageProcessor | Image processor |
| storage | Upload storage |
| temporaryFile | Temporary file |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException |  |

## See Also

* interface [IUploadOptions](../Serenity.Net.Core/../../Serenity.ComponentModel/IUploadOptions.md)
* interface [IUploadValidator](../Serenity.Net.Services/../../Serenity.Web/IUploadValidator.md)
* interface [IImageProcessor](../Serenity.Net.Services/../../global/IImageProcessor.md)
* interface [IUploadStorage](../Serenity.Net.Services/../../Serenity.Web/IUploadStorage.md)
* class [FileUploadBehavior](../FileUploadBehavior.md)