# BaseUploadEditorAttribute constructor

Sets editor type as "ImageUpload", which only allows image files. Make sure you use this attribute in Row.cs, not Form.cs as the image upload behavior only works if it is in the row, otherwise your files will stay in the temporary directory.

```csharp
protected BaseUploadEditorAttribute(string editorType)
```

| parameter | description |
| --- | --- |
| editorType | Type of the editor. |

## Remarks

Initializes a new instance of the [`BaseUploadEditorAttribute`](../BaseUploadEditorAttribute.md) class.

## See Also

* class [CustomEditorAttribute](../CustomEditorAttribute.md)
* class [BaseUploadEditorAttribute](../BaseUploadEditorAttribute.md)