# UploadStorageExtensions.ScaleImageAndCreateAllThumbs method
**namespace:** *[Serenity.Web](../../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Depending on the image upload options, scales image, creates default and additional thumbs and saves them to the upload storage files.

```csharp
public static string ScaleImageAndCreateAllThumbs(object image, IImageProcessor imageProcessor, 
    IUploadImageOptions options, IUploadStorage uploadStorage, string temporaryFile, 
    OverwriteOption overwrite)
```

| parameter | description |
| --- | --- |
| image | Input image |
| imageProcessor | Image processor |
| options | Upload image options |
| uploadStorage | Upload storage |
| temporaryFile | Temporary file |
| overwrite | Overwrite option |

## Return Value

Temporary file

## See Also

* interface [IImageProcessor](../IImageProcessor.md)
* interface [IUploadImageOptions](../Serenity.Net.Core/../../Serenity.ComponentModel/IUploadImageOptions.md)
* interface [IUploadStorage](../IUploadStorage.md)
* enum [OverwriteOption](../OverwriteOption.md)
* class [UploadStorageExtensions](../UploadStorageExtensions.md)