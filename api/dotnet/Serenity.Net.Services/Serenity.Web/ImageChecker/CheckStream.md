# ImageChecker.CheckStream method
**namespace:** *[Serenity.Web](../../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Checks if the given image if it is a valid or not. If so, controls its compliance to constraints

```csharp
public ImageCheckResult CheckStream(Stream inputStream, IImageProcessor imageProcessor, 
    bool returnImage, out object image, out ImageFormatInfo formatInfo, ILogger logger = null)
```

| parameter | description |
| --- | --- |
| inputStream | Stream which contains image data |
| imageProcessor | Image processor |
| returnImage | Does image required to be returned? If not requested, it will be disposed at the end of processing |
| image | When method returns contains the image object. If returnImage false it will contain null |
| formatInfo | Contains image format info on return |
| logger | Logger |

## Return Value

Image validation result. One of [`ImageCheckResult`](../ImageCheckResult.md) values. If the result is one of GIFImage, JPEGImage, PNGImage, the checking is successful. Rest of results are invalid.

## See Also

* enum [ImageCheckResult](../ImageCheckResult.md)
* interface [IImageProcessor](../IImageProcessor.md)
* class [ImageFormatInfo](../ImageFormatInfo.md)
* class [ImageChecker](../ImageChecker.md)