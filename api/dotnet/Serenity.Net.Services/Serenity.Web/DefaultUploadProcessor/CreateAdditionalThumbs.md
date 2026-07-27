# DefaultUploadProcessor.CreateAdditionalThumbs method
**namespace:** *[Serenity.Web](../../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Creates additional thumbs if specified in the upload image options, and saves them to the target upload storage

```csharp
protected virtual IEnumerable<ScaleImageAsResult> CreateAdditionalThumbs(object image, 
    IUploadImageOptions options, string imageFile)
```

| parameter | description |
| --- | --- |
| image | Image |
| options | Upload image options |
| imageFile | Main image file |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | image, options or temporaryFile is null |
| ArgumentOutOfRangeException | options.ThumbSizes contains invalid values |

## See Also

* class [ScaleImageAsResult](../DefaultUploadProcessor.ScaleImageAsResult.md)
* interface [IUploadImageOptions](../Serenity.Net.Core/../../Serenity.ComponentModel/IUploadImageOptions.md)
* class [DefaultUploadProcessor](../DefaultUploadProcessor.md)