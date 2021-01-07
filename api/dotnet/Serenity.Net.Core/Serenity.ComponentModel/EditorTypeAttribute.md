# EditorTypeAttribute class
**namespace:** *[Serenity.ComponentModel](../README.md#serenity.componentmodel-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Sets editor type of the target property.

```csharp
[AttributeUsage(AttributeTargets.All)]
public class EditorTypeAttribute : Attribute
```

## Public Members

| name | description |
| --- | --- |
| [EditorTypeAttribute](EditorTypeAttribute/EditorTypeAttribute.md)(…) | Initializes a new instance of the [`EditorTypeAttribute`](EditorTypeAttribute.md) class. |
| [EditorType](EditorTypeAttribute/EditorType.md) { get; } | Gets the type of the editor. |
| virtual [SetParams](EditorTypeAttribute/SetParams.md)(…) | Transfers the current editor parameters to specified editorParams dictionary. |

## See Also

* **Source:** *[EditorTypeAttribute.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Core/ComponentModel/PropertyGrid/Editing/EditorTypeAttribute.cs)*