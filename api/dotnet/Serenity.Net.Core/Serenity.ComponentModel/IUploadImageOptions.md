# IUploadImageOptions interface
**namespace:** *[Serenity.ComponentModel](../README.md#serenity.componentmodel-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Options for the uploaded image and thumbnails

```csharp
public interface IUploadImageOptions : IUploadOptions
```

## Members

| name | description |
| --- | --- |
| [ScaleBackColor](IUploadImageOptions/ScaleBackColor.md) { get; set; } | Background color to use when padding image |
| [ScaleHeight](IUploadImageOptions/ScaleHeight.md) { get; } | What height image should be scaled to. Default value of 0 disables it. |
| [ScaleMode](IUploadImageOptions/ScaleMode.md) { get; } | What kind of image scaling should be used to generate image. |
| [ScaleQuality](IUploadImageOptions/ScaleQuality.md) { get; } | Quality of scaled image (not thumb). |
| [ScaleSmaller](IUploadImageOptions/ScaleSmaller.md) { get; } | Should image be scaled up to requested size when its smaller |
| [ScaleWidth](IUploadImageOptions/ScaleWidth.md) { get; } | What width image should be scaled to. Default value of 0 disables it. |
| [ThumbBackColor](IUploadImageOptions/ThumbBackColor.md) { get; set; } | Background color to use when padding thumbnails |
| [ThumbHeight](IUploadImageOptions/ThumbHeight.md) { get; set; } | Thumbnail height for the default thumbnail. Default is 0, e.g. disabled. |
| [ThumbMode](IUploadImageOptions/ThumbMode.md) { get; } | What kind of image scaling should be used to generate thumbnails. |
| [ThumbQuality](IUploadImageOptions/ThumbQuality.md) { get; } | Quality of thumbnails. |
| [ThumbSizes](IUploadImageOptions/ThumbSizes.md) { get; } | List of thumbnail sizes requested. Something like "96x96;128x128;200x200" |
| [ThumbWidth](IUploadImageOptions/ThumbWidth.md) { get; set; } | Thumbnail width for the default thumbnail. Default is 0, e.g. disabled. |

## See Also

* interface [IUploadOptions](IUploadOptions.md)