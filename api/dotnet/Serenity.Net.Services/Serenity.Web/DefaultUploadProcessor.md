# DefaultUploadProcessor class
**namespace:** *[Serenity.Web](../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Default implementation for [`IUploadProcessor`](IUploadProcessor.md)

```csharp
public class DefaultUploadProcessor : IUploadProcessor
```

| parameter | description |
| --- | --- |
| imageProcessor | Image processor |
| uploadStorage | Upload storage |
| uploadValidator | Upload validator |
| logger | Logger |
| avScanner | Optional antivirus scanner |

## Public Members

| name | description |
| --- | --- |
| [DefaultUploadProcessor](DefaultUploadProcessor/DefaultUploadProcessor.md)(…) | Default implementation for [`IUploadProcessor`](IUploadProcessor.md) |
| virtual [CreateDefaultThumb](DefaultUploadProcessor/CreateDefaultThumb.md)(…) | Creates the default thumbnail for image if the size is provided in the upload image options (ThumbWidth and ThumbHeight &gt;= 0) and saves it to the target upload storage file |
| virtual [Process](DefaultUploadProcessor/Process.md)(…) |  |
| class [ScaleImageAsResult](DefaultUploadProcessor.ScaleImageAsResult.md) | Result for the scale image as operation |

## Protected Members

| name | description |
| --- | --- |
| readonly [avScanner-](DefaultUploadProcessor/avScanner-.md) | AV Scanner |
| readonly [imageProcessor-](DefaultUploadProcessor/imageProcessor-.md) | Image processor |
| readonly [logger-](DefaultUploadProcessor/logger-.md) | Logger |
| readonly [uploadStorage-](DefaultUploadProcessor/uploadStorage-.md) | Upload storage |
| readonly [uploadValidator-](DefaultUploadProcessor/uploadValidator-.md) | Upload validator |
| virtual [CreateAdditionalThumbs](DefaultUploadProcessor/CreateAdditionalThumbs.md)(…) | Creates additional thumbs if specified in the upload image options, and saves them to the target upload storage |
| virtual [ProcessImage](DefaultUploadProcessor/ProcessImage.md)(…) | Depending on the image upload options, scales image, creates default and additional thumbs and saves them to the upload storage files. |
| virtual [ScaleImageAs](DefaultUploadProcessor/ScaleImageAs.md)(…) | Scales an image and saves it to an upload storage file |
| virtual [ScaleMainImage](DefaultUploadProcessor/ScaleMainImage.md)(…) | Scales the temporary image with provided upload image options if required based on the options and saves the result to the target upload storage file |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException |  |

## Remarks

Creates a new instance of the class

## See Also

* interface [IUploadProcessor](IUploadProcessor.md)
* **Source:** *[DefaultUploadProcessor.cs](https://github.com/serenity-is/Serenity/blob/master/src/Services/Upload/DefaultUploadProcessor.cs)*