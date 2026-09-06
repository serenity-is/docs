# IUploadImageConstraints interface
**namespace:** *[Serenity.ComponentModel](../README.md#serenity.componentmodel-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Constraints for the uploaded image.

```csharp
public interface IUploadImageConstraints : IUploadOptions
```

## Members

| name | description |
| --- | --- |
| [IgnoreEmptyImage](IUploadImageConstraints/IgnoreEmptyImage.md) { get; } | If the file contains an empty image, ignore it instead of raising an error. |
| [IgnoreExtensionMismatch](IUploadImageConstraints/IgnoreExtensionMismatch.md) { get; } | If set to false, the upload behavior raises an error when it detects the extension does not match the actual format of the uploaded file. For example, if the uploaded file is "test.jpg" but it has a "png" image inside, it raises an error. Default is true, so such mismatches are ignored. |
| [IgnoreInvalidImage](IUploadImageConstraints/IgnoreInvalidImage.md) { get; } | If the file contains an invalid image, ignore it instead of raising an error. |
| [MaxHeight](IUploadImageConstraints/MaxHeight.md) { get; } | Maximum height in pixels of the uploaded image. |
| [MaxWidth](IUploadImageConstraints/MaxWidth.md) { get; } | Maximum width in pixels of the uploaded image. |
| [MinHeight](IUploadImageConstraints/MinHeight.md) { get; } | Minimum height in pixels of the uploaded image. |
| [MinWidth](IUploadImageConstraints/MinWidth.md) { get; } | Minimum width in pixels of the uploaded image. |

## See Also

* interface [IUploadOptions](./IUploadOptions.md)
* **Source:** *[IUploadImageConstraints.cs](https://github.com/serenity-is/Serenity/blob/a5013fdf777dbbd87589205ddffcb67f18bea673/src/core/ComponentModel/Upload/IUploadImageConstraints.cs)*