# DefaultUploadValidator class
**namespace:** *[Serenity.Web](../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Default implementation for [`IUploadValidator`](IUploadValidator.md)

```csharp
public class DefaultUploadValidator : IUploadValidator
```

| parameter | description |
| --- | --- |
| imageProcessor | Image processor |
| localizer | Text localizer |
| uploadSettings | Upload settings |
| logger | Exception logger |

## Public Members

| name | description |
| --- | --- |
| [DefaultUploadValidator](DefaultUploadValidator/DefaultUploadValidator.md)(…) | Default implementation for [`IUploadValidator`](IUploadValidator.md) |
| [ValidateFile](DefaultUploadValidator/ValidateFile.md)(…) |  |
| [ValidateImage](DefaultUploadValidator/ValidateImage.md)(…) |  |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | imageProcessor or localizer is null |

## Remarks

Creates a new instance of the class

## See Also

* interface [IUploadValidator](IUploadValidator.md)
* **Source:** *[DefaultUploadValidator.cs](https://github.com/serenity-is/Serenity/blob/master/src/Services/Upload/DefaultUploadValidator.cs)*