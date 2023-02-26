# IUploadEditor interface
**namespace:** *[Serenity.ComponentModel](../README.md#serenity.componentmodel-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Runs FileUploadBehavior or MultipleFileUploadBehavior behaviors. Make sure you use this attribute in Row.cs, not Form.cs as the image upload behavior only works if it is in row, otherwise your files will stay in temporary directory.

```csharp
public interface IUploadEditor
```

## Members

| name | description |
| --- | --- |
| [DisableDefaultBehavior](IUploadEditor/DisableDefaultBehavior.md) { get; } | If you don't want FileUploadBehavior / MultipleFileUploadBehavior to process this upload, and want to handle it manually, set to true (not recommended) |
| [IsMultiple](IUploadEditor/IsMultiple.md) { get; } | Sets if the editor is going to be used for multiple file upload. |
| [UploadIntent](IUploadEditor/UploadIntent.md) { get; } | This is a property used to match uploaded files with their origins. If not specified, will be calculated as: "FullTypeName,AssemblyName:PropertyName" from the attribute this property is placed on. This way the temporary upload processor can locate the original attribute by its type name and validate its settings or generate the expected thumbnail types. |

## See Also

* **Source:** *[IUploadEditor.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Core/ComponentModel/Upload/IUploadEditor.cs)*