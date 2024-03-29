# MultipleImageUploadEditorAttribute class
**namespace:** *[Serenity.ComponentModel](../README.md#serenity.componentmodel-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Sets editor type to "MultipleImageUpload" which doesn't allow non-image file types by default.

```csharp
[AttributeUsage(AttributeTargets.All)]
public class MultipleImageUploadEditorAttribute : BaseUploadEditorAttribute
```

## Public Members

| name | description |
| --- | --- |
| [MultipleImageUploadEditorAttribute](MultipleImageUploadEditorAttribute/MultipleImageUploadEditorAttribute.md)() | Initializes a new instance of the [`MultipleImageUploadEditorAttribute`](MultipleImageUploadEditorAttribute.md) class. |
| override [IsMultiple](MultipleImageUploadEditorAttribute/IsMultiple.md) { get; } |  |
| const [Key](MultipleImageUploadEditorAttribute/Key.md) | Editor type key |

## See Also

* class [ImageUploadEditorAttribute](ImageUploadEditorAttribute.md)
* class [BaseUploadEditorAttribute](BaseUploadEditorAttribute.md)
* **Source:** *[MultipleImageUploadEditorAttribute.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Core/ComponentModel/Upload/MultipleImageUploadEditorAttribute.cs)*