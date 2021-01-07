# ImageScaleMode enumeration
**namespace:** *[Serenity.Web](../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Thumbnail scaling modes

```csharp
public enum ImageScaleMode
```

## Values

| name | value | description |
| --- | --- | --- |
| StretchToFit | `0` | In this mode, thumbnail is generated just at the size requested. If thumbnail width or height specified only, than thumbnail will have same aspect ratio, otherwise if thumbnail and source is not at same ratio, thumbnail will have a narrowed or widened look. |
| PreserveRatioNoFill | `1` | Try to keep original aspect ratio of source image while generating the thumbnail. If only width or height is set, it works same way with StretchToFit. When both set, thumbnail width or height will be decreased suitably. |
| PreserveRatioWithFill | `2` | It is logically same with PreserveRatioNoFill but this time instead of decreasing thumbnail width or height, empty parts are filled. |
| CropSourceImage | `3` | In this mode only central part of source image (horizontally or vertically) is taken to keep thumbnail at requested size if aspect ratio of source image is different. |

## See Also

* **Source:** *[ImageScaleMode.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Core/ComponentModel/Upload/ImageScaleMode.cs)*