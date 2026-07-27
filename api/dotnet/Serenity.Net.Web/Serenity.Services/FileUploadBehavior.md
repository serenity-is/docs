# FileUploadBehavior class
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Web](../README.md)*

Behavior class that handles FileUploadEditorAttribute and ImageUploadEditorAttribute.

```csharp
public class FileUploadBehavior : BaseSaveDeleteBehavior, IFieldBehavior, IImplicitBehavior
```

| parameter | description |
| --- | --- |
| storage | Upload storage |
| uploadProcessor | Upload processor |
| formatSanitizer | Filename format sanitizer |

## Public Members

| name | description |
| --- | --- |
| [FileUploadBehavior](FileUploadBehavior/FileUploadBehavior.md)(…) | Behavior class that handles FileUploadEditorAttribute and ImageUploadEditorAttribute. |
| [Target](FileUploadBehavior/Target.md) { get; set; } |  |
| [ActivateFor](FileUploadBehavior/ActivateFor.md)(…) |  |
| override [OnAfterDelete](FileUploadBehavior/OnAfterDelete.md)(…) |  |
| override [OnAfterSave](FileUploadBehavior/OnAfterSave.md)(…) |  |
| override [OnBeforeSave](FileUploadBehavior/OnBeforeSave.md)(…) |  |
| override [OnPrepareQuery](FileUploadBehavior/OnPrepareQuery.md)(…) |  |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | One of the arguments is null |

## Remarks

Creates a new instance of the class.

## See Also

* class [BaseSaveDeleteBehavior](../Serenity.Net.Services/BaseSaveDeleteBehavior.md)
* interface [IFieldBehavior](../Serenity.Net.Services/IFieldBehavior.md)
* interface [IImplicitBehavior](../Serenity.Net.Services/IImplicitBehavior.md)
* **Source:** *[FileUploadBehavior.cs](https://github.com/serenity-is/Serenity/blob/master/src/Web/Upload/FileUploadBehavior.cs)*