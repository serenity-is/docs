# DefaultUploadProcessor.ProcessImage method
**namespace:** *[Serenity.Web](../../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Depending on the image upload options, scales image, creates default and additional thumbs and saves them to the upload storage files.

```csharp
protected virtual string ProcessImage(object image, IUploadImageOptions options, string imageFile)
```

| parameter | description |
| --- | --- |
| image | Input image |
| options | Upload image options |
| imageFile | Image file path |

## Return Value

Scaled image file path. It might be different then the passed file if scaling is performed. E.g. the uploaded file might be .png while the scaled image might be .jpg

## See Also

* interface [IUploadImageOptions](../Serenity.Net.Core/../../Serenity.ComponentModel/IUploadImageOptions.md)
* class [DefaultUploadProcessor](../DefaultUploadProcessor.md)