# HintAttribute class
**namespace:** *[Serenity.ComponentModel](../README.md#serenity.componentmodel-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Sets a hint for a form field. The hint is shown when the field label is hovered. This has no effect on columns.

```csharp
[AttributeUsage(AttributeTargets.All)]
public class HintAttribute : Attribute, IHasTextKey
```

| parameter | description |
| --- | --- |
| hint | The hint. |

## Public Members

| name | description |
| --- | --- |
| [HintAttribute](HintAttribute/HintAttribute.md)() | Creates a new instance of the [`HintAttribute`](./HintAttribute.md) class. Use this overload for creating a hint with a local text key, and no default hint. |
| [HintAttribute](HintAttribute/HintAttribute.md)(…) | Sets a hint for a form field. The hint is shown when the field label is hovered. This has no effect on columns. |
| [Hint](HintAttribute/Hint.md) { get; } | Gets the hint. |
| [TextKey](HintAttribute/TextKey.md) { get; set; } | Gets or sets the local text key for the category. |

## Remarks

Initializes a new instance of the [`HintAttribute`](./HintAttribute.md) class.

## See Also

* interface [IHasTextKey](../Serenity.Services/IHasTextKey.md)
* **Source:** *[HintAttribute.cs](https://github.com/serenity-is/Serenity/blob/0c34357a17d56458ca5b7a3be25f42666b9eb050/src/core/ComponentModel/PropertyGrid/HintAttribute.cs)*