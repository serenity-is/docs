# DefaultUploadProcessor.ScaleImageAs method
**namespace:** *[Serenity.Web](../../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Scales an image and saves it to an upload storage file

```csharp
protected virtual ScaleImageAsResult ScaleImageAs(object image, int width, int height, 
    ImageScaleMode mode, string backgroundColor, ImageEncoderParams encoderParams, 
    string targetFile, string primaryFile)
```

| parameter | description |
| --- | --- |
| image | Source image |
| width | Target width |
| height | Target height |
| mode | Scale mode |
| backgroundColor | Pad color |
| encoderParams | Encoder parameters for target image |
| targetFile | Path |
| primaryFile | Primary file which this is a derivative of. Pass null if this is the main image itself, not a thumbnail. and not a thumbnail. |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | One of inputs is null |

## See Also

* class [ScaleImageAsResult](../DefaultUploadProcessor.ScaleImageAsResult.md)
* enum [ImageScaleMode](../Serenity.Net.Core/../ImageScaleMode.md)
* class [ImageEncoderParams](../ImageEncoderParams.md)
* class [DefaultUploadProcessor](../DefaultUploadProcessor.md)