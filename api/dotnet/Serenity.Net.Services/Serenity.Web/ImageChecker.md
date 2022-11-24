# ImageChecker class
**namespace:** *[Serenity.Web](../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Checks stream data if valid image file and validate required conditions.

```csharp
public class ImageChecker
```

## Public Members

| name | description |
| --- | --- |
| [ImageChecker](ImageChecker/ImageChecker.md)() | The default constructor. |
| [DataSize](ImageChecker/DataSize.md) { get; } | Gets data size of the validated image |
| [Height](ImageChecker/Height.md) { get; } | Gets height of the validate image |
| [MaxDataSize](ImageChecker/MaxDataSize.md) { get; set; } | Gets/sets maximum file size allowed |
| [MaxHeight](ImageChecker/MaxHeight.md) { get; set; } | Gets/sets maximum height allowed. 0 means any height. |
| [MaxWidth](ImageChecker/MaxWidth.md) { get; set; } | Gets/sets maximum width allowed. 0 means any width. |
| [Milliseconds](ImageChecker/Milliseconds.md) { get; } | Gets the time passed during validating the image |
| [MinHeight](ImageChecker/MinHeight.md) { get; set; } | Gets/sets minimum height allowed. 0 means any height. |
| [MinWidth](ImageChecker/MinWidth.md) { get; set; } | Gets/sets minimum width allowed. 0 means any width. |
| [Width](ImageChecker/Width.md) { get; } | Gets width of the validated image |
| [CheckSizeConstraints](ImageChecker/CheckSizeConstraints.md)(…) | Checks an image width and height against size constraints |
| [CheckStream](ImageChecker/CheckStream.md)(…) | Checks if the given image if it is a valid or not. If so, controls its compliance to constraints |
| [FormatErrorMessage](ImageChecker/FormatErrorMessage.md)(…) | Formats an [`ImageCheckResult`](ImageCheckResult.md) error message |

## See Also

* **Source:** *[ImageChecker.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Services/Upload/ImageChecker.cs)*