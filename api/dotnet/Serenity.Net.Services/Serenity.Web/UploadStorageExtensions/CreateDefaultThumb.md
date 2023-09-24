# UploadStorageExtensions.CreateDefaultThumb method
**namespace:** *[Serenity.Web](../../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Creates the default thumbnail for image if the size is provided in the upload image options (ThumbWidth and ThumbHeight &gt;= 0) and saves it to the target upload storage file

```csharp
public static string CreateDefaultThumb(object image, IImageProcessor imageProcessor, 
    IUploadImageOptions options, IUploadStorage uploadStorage, string temporaryFile, 
    OverwriteOption overwrite)
```

| parameter | description |
| --- | --- |
| image | Image |
| imageProcessor | Image processor |
| options | Upload image options |
| uploadStorage | Upload storage |
| temporaryFile | Input temporary file |
| overwrite | Overwrite option |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | image, options or temporaryFile is null |

## See Also

* interface [IImageProcessor](../IImageProcessor.md)
* interface [IUploadImageOptions](../Serenity.Net.Core/../../Serenity.ComponentModel/IUploadImageOptions.md)
* interface [IUploadStorage](../IUploadStorage.md)
* enum [OverwriteOption](../OverwriteOption.md)
* class [UploadStorageExtensions](../UploadStorageExtensions.md)