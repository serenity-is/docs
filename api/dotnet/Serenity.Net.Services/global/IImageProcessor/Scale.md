# IImageProcessor.Scale method
**namespace:** *[global](../../README.md#global-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Generates a thumbnail of the source image based on parameters.

```csharp
public object Scale(object image, int width, int height, ImageScaleMode mode, 
    string backgroundColor, bool inplace)
```

| parameter | description |
| --- | --- |
| image | Image object to generate thumbnail for (required) |
| width | Thumbnail width. If 0, width is calculated by source aspect ratio. Only one of width or height can be zero. |
| height | Thumbnail height. If 0, height is calculated by source aspect ratio. Only one of width or height can be zero. |
| mode | Thumbnail generation mode. It is only important when both dimensions are specified and source aspect ratio is different than thumbnail (see ImageScaleMode). |
| backgroundColor | Specifies fill color for PreserveRatioWithFill mode. |

## Return Value

Generated thumbnail image. Should be disposed by caller.

## Remarks

Thumbnail width or height must be greater than 0. Otherwise an empty image is generated.When ImageScaleMode.PreserveRatioNoFill used and both dimensions are set, if aspect ratio of source image and thumbnail doesn't match, thumbnail's horizontal or vertical size may be different than requested one. In, PreserveRatioWithFill mode thumbnail size will be at requested size but empty parts are filled with a solid color.

## See Also

* enum [ImageScaleMode](../Serenity.Net.Core/../../Serenity.Web/ImageScaleMode.md)
* interface [IImageProcessor](../IImageProcessor.md)