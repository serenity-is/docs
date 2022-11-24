# UploadStorageExtensions.CreateAdditionalThumbs method
**namespace:** *[Serenity.Web](../../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Creates additional thumbs if specified in the upload image options, and saves them to the target upload storage

```csharp
public static void CreateAdditionalThumbs(object image, IImageProcessor imageProcessor, 
    IUploadImageOptions options, IUploadStorage uploadStorage, string temporaryFile, 
    OverwriteOption overwrite)
```

| parameter | description |
| --- | --- |
| image | Image |
| imageProcessor | Image processor |
| options | Upload image options |
| uploadStorage | Target upload storage |
| temporaryFile | Input temporary file |
| overwrite | Overwrite option |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | image, options or temporaryFile is null |
| ArgumentOutOfRangeException | options.ThumbSizes contains invalid values |

## See Also

* interface [IImageProcessor](../../global/IImageProcessor.md)
* interface [IUploadImageOptions](../Serenity.Net.Core/../../Serenity.ComponentModel/IUploadImageOptions.md)
* interface [IUploadStorage](../IUploadStorage.md)
* enum [OverwriteOption](../OverwriteOption.md)
* class [UploadStorageExtensions](../UploadStorageExtensions.md)