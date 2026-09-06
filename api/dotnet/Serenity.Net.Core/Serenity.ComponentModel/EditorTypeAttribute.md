# EditorTypeAttribute class
**namespace:** *[Serenity.ComponentModel](../README.md#serenity.componentmodel-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Sets the editor type of the target property.

```csharp
[AttributeUsage(AttributeTargets.All)]
public class EditorTypeAttribute : Attribute
```

| parameter | description |
| --- | --- |
| type | The type. |

## Public Members

| name | description |
| --- | --- |
| [EditorTypeAttribute](EditorTypeAttribute/EditorTypeAttribute.md)(…) | Sets the editor type of the target property. |
| [EditorType](EditorTypeAttribute/EditorType.md) { get; } | Gets the type of the editor. |
| virtual [SetParams](EditorTypeAttribute/SetParams.md)(…) | Transfers the current editor parameters to specified editorParams dictionary. |

## Remarks

Initializes a new instance of the [`EditorTypeAttribute`](./EditorTypeAttribute.md) class.

## See Also

* **Source:** *[EditorTypeAttribute.cs](https://github.com/serenity-is/Serenity/blob/a5013fdf777dbbd87589205ddffcb67f18bea673/src/core/ComponentModel/PropertyGrid/Editing/EditorTypeAttribute.cs)*