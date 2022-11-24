# DefaultUploadValidator constructor
**namespace:** *[Serenity.Web](../../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Creates a new instance of the class

```csharp
public DefaultUploadValidator(IImageProcessor imageProcessor, ITextLocalizer localizer, 
    IExceptionLogger logger = null)
```

| parameter | description |
| --- | --- |
| imageProcessor | Image processor |
| localizer | Text localizer |
| logger | Exception logger |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | imageProcessor or localizer is null |

## See Also

* interface [IImageProcessor](../../global/IImageProcessor.md)
* interface [ITextLocalizer](../Serenity.Net.Core/../../Serenity/ITextLocalizer.md)
* interface [IExceptionLogger](../Serenity.Net.Core/../../Serenity.Abstractions/IExceptionLogger.md)
* class [DefaultUploadValidator](../DefaultUploadValidator.md)