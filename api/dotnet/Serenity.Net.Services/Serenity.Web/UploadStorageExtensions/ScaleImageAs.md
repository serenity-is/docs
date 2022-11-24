# UploadStorageExtensions.ScaleImageAs method
**namespace:** *[Serenity.Web](../../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Scales an image and saves it to an upload storage file

```csharp
public static string ScaleImageAs(object image, IImageProcessor imageProcessor, int width, 
    int height, ImageScaleMode mode, string backgroundColor, string mimeType, 
    ImageEncoderParams encoderParams, IUploadStorage uploadStorage, string path, 
    OverwriteOption overwrite)
```

| parameter | description |
| --- | --- |
| image | Source image |
| imageProcessor | Image processor |
| width | Target width |
| height | Target height |
| mode | Scale mode |
| backgroundColor | Pad color |
| mimeType | Mime type of target image file |
| encoderParams | Encoder parameters for target image |
| uploadStorage | Upload storage |
| path | Path |
| overwrite | Overwrite option |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | One of inputs is null |
| ArgumentOutOfRangeException | Width or height is less than zero |

## See Also

* interface [IImageProcessor](../../global/IImageProcessor.md)
* enum [ImageScaleMode](../Serenity.Net.Core/../ImageScaleMode.md)
* class [ImageEncoderParams](../ImageEncoderParams.md)
* interface [IUploadStorage](../IUploadStorage.md)
* enum [OverwriteOption](../OverwriteOption.md)
* class [UploadStorageExtensions](../UploadStorageExtensions.md)