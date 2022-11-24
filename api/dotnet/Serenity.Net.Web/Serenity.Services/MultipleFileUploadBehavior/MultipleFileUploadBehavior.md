# MultipleFileUploadBehavior constructor
**namespace:** *[Serenity.Services](../../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Web](../../README.md)*

Creates a new instance of the class

```csharp
public MultipleFileUploadBehavior(IUploadValidator uploadValidator, IImageProcessor imageProcessor, 
    IUploadStorage storage)
```

| parameter | description |
| --- | --- |
| uploadValidator | Upload validator |
| imageProcessor | Image processor |
| storage | Upload storage |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | One of the arguments is null |

## See Also

* interface [IUploadValidator](../Serenity.Net.Services/../../Serenity.Web/IUploadValidator.md)
* interface [IImageProcessor](../Serenity.Net.Services/../../global/IImageProcessor.md)
* interface [IUploadStorage](../Serenity.Net.Services/../../Serenity.Web/IUploadStorage.md)
* class [MultipleFileUploadBehavior](../MultipleFileUploadBehavior.md)