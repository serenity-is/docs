# FileUploadBehavior constructor
**namespace:** *[Serenity.Services](../../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Web](../../README.md)*

Behavior class that handles FileUploadEditorAttribute and ImageUploadEditorAttribute.

```csharp
public FileUploadBehavior(IUploadStorage storage, IUploadProcessor uploadProcessor, 
    IFilenameFormatSanitizer formatSanitizer = null)
```

| parameter | description |
| --- | --- |
| storage | Upload storage |
| uploadProcessor | Upload processor |
| formatSanitizer | Filename format sanitizer |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | One of the arguments is null |

## Remarks

Creates a new instance of the class.

## See Also

* interface [IUploadStorage](../Serenity.Net.Services/../../Serenity.Web/IUploadStorage.md)
* interface [IUploadProcessor](../Serenity.Net.Services/../../Serenity.Web/IUploadProcessor.md)
* interface [IFilenameFormatSanitizer](../Serenity.Net.Core/../../Serenity.ComponentModel/IFilenameFormatSanitizer.md)
* class [FileUploadBehavior](../FileUploadBehavior.md)