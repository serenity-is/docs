# FileUploadBehavior class
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Web](../README.md)*

Behavior class that handles FileUploadEditorAttribute and ImageUploadEditorAttribute.

```csharp
public class FileUploadBehavior : BaseSaveDeleteBehavior, IFieldBehavior, IImplicitBehavior
```

## Public Members

| name | description |
| --- | --- |
| [FileUploadBehavior](FileUploadBehavior/FileUploadBehavior.md)(…) | Creates a new instance of the class. |
| [Target](FileUploadBehavior/Target.md) { get; set; } |  |
| [ActivateFor](FileUploadBehavior/ActivateFor.md)(…) |  |
| override [OnAfterDelete](FileUploadBehavior/OnAfterDelete.md)(…) |  |
| override [OnAfterSave](FileUploadBehavior/OnAfterSave.md)(…) |  |
| override [OnBeforeSave](FileUploadBehavior/OnBeforeSave.md)(…) |  |
| override [OnPrepareQuery](FileUploadBehavior/OnPrepareQuery.md)(…) |  |
| static [CheckUploadedImageAndCreateThumbs](FileUploadBehavior/CheckUploadedImageAndCreateThumbs.md)(…) | Checks the uploaded image and creates thumbs if required based on options |

## See Also

* class [BaseSaveDeleteBehavior](../Serenity.Net.Services/BaseSaveDeleteBehavior.md)
* interface [IFieldBehavior](../Serenity.Net.Services/IFieldBehavior.md)
* interface [IImplicitBehavior](../Serenity.Net.Services/IImplicitBehavior.md)
* **Source:** *[FileUploadBehavior.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Web/Upload/FileUploadBehavior.cs)*