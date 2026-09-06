# MaskedEditorAttribute class
**namespace:** *[Serenity.ComponentModel](../README.md#serenity.componentmodel-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Indicates that the target property should use a "Masked" editor. Note that this requires https://www.npmjs.com/package/jquery.maskedinput, e.g. jquery.maskedinput.js which can be installed via libman or npm, and referenced in your scripts (via appsettings.bundles.json).

```csharp
[AttributeUsage(AttributeTargets.All)]
public class MaskedEditorAttribute : CustomEditorAttribute
```

## Public Members

| name | description |
| --- | --- |
| [MaskedEditorAttribute](MaskedEditorAttribute/MaskedEditorAttribute.md)() | Initializes a new instance of the [`MaskedEditorAttribute`](./MaskedEditorAttribute.md) class. |
| [Mask](MaskedEditorAttribute/Mask.md) { get; set; } | Gets or sets the mask. a = letter, 9 = numeric, * = alphanumeric. |
| [Placeholder](MaskedEditorAttribute/Placeholder.md) { get; set; } | Gets or sets the placeholder. |
| const [Key](MaskedEditorAttribute/Key.md) | Editor type key |

## See Also

* class [CustomEditorAttribute](./CustomEditorAttribute.md)
* **Source:** *[MaskedEditorAttribute.cs](https://github.com/serenity-is/Serenity/blob/a5013fdf777dbbd87589205ddffcb67f18bea673/src/core/ComponentModel/PropertyGrid/EditorTypes/MaskedEditorAttribute.cs)*