# BaseUploadEditorAttribute constructor
**namespace:** *[Serenity.ComponentModel](../../README.md#serenity.componentmodel-namespace)*   **assembly**: *[Serenity.Net.Core](../../README.md)*

Sets editor type as "ImageUpload", which only allows image files. Make sure you use this attribute in Row.cs, not Form.cs as the image upload behavior only works if it is in row, otherwise your files will stay in temporary directory.

```csharp
protected BaseUploadEditorAttribute(string editorType)
```

| parameter | description |
| --- | --- |
| editorType | Type of the editor. |

## Remarks

Initializes a new instance of the [`ImageUploadEditorAttribute`](../ImageUploadEditorAttribute.md) class.

## See Also

* class [CustomEditorAttribute](../CustomEditorAttribute.md)
* class [BaseUploadEditorAttribute](../BaseUploadEditorAttribute.md)