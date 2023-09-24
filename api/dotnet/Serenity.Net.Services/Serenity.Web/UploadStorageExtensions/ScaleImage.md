# UploadStorageExtensions.ScaleImage method
**namespace:** *[Serenity.Web](../../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Scales the temporary image with provided upload image options if required based on the options and saves the result to the target upload storage file

```csharp
public static string ScaleImage(object image, IImageProcessor imageProcessor, 
    IUploadImageOptions options, IUploadStorage uploadStorage, string temporaryFile, 
    OverwriteOption overwrite)
```

| parameter | description |
| --- | --- |
| image | Image object |
| imageProcessor | Image processor |
| options | Image upload options |
| uploadStorage | Upload storage |
| temporaryFile | Temporary input file |
| overwrite | Overwrite |

## Return Value

The resulting image file path

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | image or options is null |

## See Also

* interface [IImageProcessor](../IImageProcessor.md)
* interface [IUploadImageOptions](../Serenity.Net.Core/../../Serenity.ComponentModel/IUploadImageOptions.md)
* interface [IUploadStorage](../IUploadStorage.md)
* enum [OverwriteOption](../OverwriteOption.md)
* class [UploadStorageExtensions](../UploadStorageExtensions.md)