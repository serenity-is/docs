# DefaultUploadValidator constructor
**namespace:** *[Serenity.Web](../../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Default implementation for [`IUploadValidator`](../IUploadValidator.md)

```csharp
public DefaultUploadValidator(IImageProcessor imageProcessor, ITextLocalizer localizer, 
    ILogger<DefaultUploadValidator> logger = null, IOptions<UploadSettings> uploadSettings = null)
```

| parameter | description |
| --- | --- |
| imageProcessor | Image processor |
| localizer | Text localizer |
| uploadSettings | Upload settings |
| logger | Exception logger |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | imageProcessor or localizer is null |

## Remarks

Creates a new instance of the class

## See Also

* interface [IImageProcessor](../IImageProcessor.md)
* interface [ITextLocalizer](../Serenity.Net.Core/../../Serenity/ITextLocalizer.md)
* class [UploadSettings](../UploadSettings.md)
* class [DefaultUploadValidator](../DefaultUploadValidator.md)