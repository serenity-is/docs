# TabAttribute class
**namespace:** *[Serenity.ComponentModel](../README.md#serenity.componentmodel-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Sets a tab for a form field.

```csharp
[AttributeUsage(AttributeTargets.All)]
public class TabAttribute : Attribute, IHasTextKey
```

| parameter | description |
| --- | --- |
| value | The value. |

## Public Members

| name | description |
| --- | --- |
| [TabAttribute](TabAttribute/TabAttribute.md)() | Initializes a new instance of the [`TabAttribute`](./TabAttribute.md) class with no value. Use this constructor when you do not want to specify a tab value, but still specify a TextKey. |
| [TabAttribute](TabAttribute/TabAttribute.md)(…) | Sets a tab for a form field. |
| [TextKey](TabAttribute/TextKey.md) { get; set; } | Gets or sets the local text key for the tab name. |
| [Value](TabAttribute/Value.md) { get; } | Gets the value. |

## Remarks

Initializes a new instance of the [`TabAttribute`](./TabAttribute.md) class.

## See Also

* interface [IHasTextKey](../Serenity.Services/IHasTextKey.md)
* **Source:** *[TabAttribute.cs](https://github.com/serenity-is/Serenity/blob/0c34357a17d56458ca5b7a3be25f42666b9eb050/src/core/ComponentModel/PropertyGrid/TabAttribute.cs)*