# ImageUploadEditorAttribute class
**namespace:** *[Serenity.ComponentModel](../README.md#serenity.componentmodel-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Sets editor type as "ImageUpload", which only allows image files. Make sure you use this attribute in Row.cs, not Form.cs as the image upload behavior only works if it is in row, otherwise your files will stay in temporary directory.

```csharp
[AttributeUsage(AttributeTargets.All)]
public class ImageUploadEditorAttribute : BaseUploadEditorAttribute
```

## Public Members

| name | description |
| --- | --- |
| [ImageUploadEditorAttribute](ImageUploadEditorAttribute/ImageUploadEditorAttribute.md)() | Initializes a new instance of the [`ImageUploadEditorAttribute`](ImageUploadEditorAttribute.md) class. |
| override [IsMultiple](ImageUploadEditorAttribute/IsMultiple.md) { get; } |  |
| const [Key](ImageUploadEditorAttribute/Key.md) | Editor type key |

## See Also

* class [CustomEditorAttribute](CustomEditorAttribute.md)
* class [BaseUploadEditorAttribute](BaseUploadEditorAttribute.md)
* **Source:** *[ImageUploadEditorAttribute.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Core/ComponentModel/Upload/ImageUploadEditorAttribute.cs)*