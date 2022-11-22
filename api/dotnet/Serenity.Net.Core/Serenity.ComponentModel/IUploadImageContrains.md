# IUploadImageContrains interface
**namespace:** *[Serenity.ComponentModel](../README.md#serenity.componentmodel-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Contstraints for the uploaded image.

```csharp
public interface IUploadImageContrains : IUploadOptions
```

## Members

| name | description |
| --- | --- |
| [IgnoreEmptyImage](IUploadImageContrains/IgnoreEmptyImage.md) { get; } | If the file contains an empty image, ignore it instead of raising an error. |
| [IgnoreExtensionMismatch](IUploadImageContrains/IgnoreExtensionMismatch.md) { get; } | If set to false, the upload behavior raises an error when it detects the extension does not match the actual format of the uploaded file. For example, if the uploaded file is "test.jpg" but it has a "png" image inside it raises an error. Default is true, so such mismatches are ignored |
| [IgnoreInvalidImage](IUploadImageContrains/IgnoreInvalidImage.md) { get; } | If the file contains an invalid image, ignore it instead of raising an error. |
| [MaxHeight](IUploadImageContrains/MaxHeight.md) { get; } | Maximum height in pixels of the uploaded image. |
| [MaxWidth](IUploadImageContrains/MaxWidth.md) { get; } | Maximum width in pixels of the uploaded image. |
| [MinHeight](IUploadImageContrains/MinHeight.md) { get; } | Minimum height in pixels of the uploaded image. |
| [MinWidth](IUploadImageContrains/MinWidth.md) { get; } | Minimum width in pixels of the uploaded image. |

## See Also

* interface [IUploadOptions](IUploadOptions.md)