# DefaultUploadProcessor.CreateDefaultThumb method
**namespace:** *[Serenity.Web](../../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Creates the default thumbnail for image if the size is provided in the upload image options (ThumbWidth and ThumbHeight &gt;= 0) and saves it to the target upload storage file

```csharp
public virtual ScaleImageAsResult CreateDefaultThumb(object image, IUploadImageOptions options, 
    string imageFile)
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

## See Also

* class [ScaleImageAsResult](../DefaultUploadProcessor.ScaleImageAsResult.md)
* interface [IUploadImageOptions](../Serenity.Net.Core/../../Serenity.ComponentModel/IUploadImageOptions.md)
* class [DefaultUploadProcessor](../DefaultUploadProcessor.md)