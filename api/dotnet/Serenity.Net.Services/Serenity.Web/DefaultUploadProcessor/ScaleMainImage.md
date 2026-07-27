# DefaultUploadProcessor.ScaleMainImage method
**namespace:** *[Serenity.Web](../../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Scales the temporary image with provided upload image options if required based on the options and saves the result to the target upload storage file

```csharp
protected virtual ScaleImageAsResult ScaleMainImage(object image, IUploadImageOptions options, 
    string imageFile)
```

| parameter | description |
| --- | --- |
| image | Image object |
| options | Image upload options |
| imageFile | Main image file |

## Return Value

The resulting image file path

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | image or options is null |

## See Also

* class [ScaleImageAsResult](../DefaultUploadProcessor.ScaleImageAsResult.md)
* interface [IUploadImageOptions](../Serenity.Net.Core/../../Serenity.ComponentModel/IUploadImageOptions.md)
* class [DefaultUploadProcessor](../DefaultUploadProcessor.md)