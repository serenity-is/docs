# MaskedEditorAttribute class
**namespace:** *[Serenity.ComponentModel](../README.md#serenity.componentmodel-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Indicates that the target property should use a "Masked" editor and also defines an automatic lookup script for row fields.

```csharp
[AttributeUsage(AttributeTargets.All)]
public class MaskedEditorAttribute : CustomEditorAttribute
```

## Public Members

| name | description |
| --- | --- |
| [MaskedEditorAttribute](MaskedEditorAttribute/MaskedEditorAttribute.md)() | Initializes a new instance of the [`MaskedEditorAttribute`](MaskedEditorAttribute.md) class. |
| [Mask](MaskedEditorAttribute/Mask.md) { get; set; } | Gets or sets the mask. a = letter, 9 = numeric, * = alphanumeric. |
| [Placeholder](MaskedEditorAttribute/Placeholder.md) { get; set; } | Gets or sets the placeholder. |

## See Also

* class [CustomEditorAttribute](CustomEditorAttribute.md)
* **Source:** *[MaskedEditorAttribute.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Core/ComponentModel/PropertyGrid/EditorTypes/MaskedEditorAttribute.cs)*