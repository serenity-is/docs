# CategoryNameAttribute class
**namespace:** *[Serenity.ComponentModel](../README.md#serenity.componentmodel-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Specifies the category name for a property or class. Unlike CategoryAttribute, it can specify a local text key.

```csharp
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Interface)]
public class CategoryNameAttribute : CategoryAttribute, IHasTextKey
```

## Public Members

| name | description |
| --- | --- |
| [CategoryNameAttribute](CategoryNameAttribute/CategoryNameAttribute.md)() | Initializes a new instance of the [`CategoryNameAttribute`](./CategoryNameAttribute.md) class with no category name. Only useful when you want to specify the category name later through the TextKey property. |
| [CategoryNameAttribute](CategoryNameAttribute/CategoryNameAttribute.md)(…) | Initializes a new instance of the [`CategoryNameAttribute`](./CategoryNameAttribute.md) class with the specified category name. |
| [TextKey](CategoryNameAttribute/TextKey.md) { get; set; } | Gets or sets the local text key for the category. |

## Examples

[CategoryName("My Display Text", TextKey = "My.Text.Key")] // with key and invariant text [CategoryName(TextKey = "My.Text.Key")] // with only key and no text [CategoryName("My Display Text")] // with only invariant text, no key [CategoryName("Db.Text.Key")] // still with only invariant text, no key unlike CategoryAttribute.

## See Also

* interface [IHasTextKey](../Serenity.Services/IHasTextKey.md)
* **Source:** *[CategoryNameAttribute.cs](https://github.com/serenity-is/Serenity/blob/0c34357a17d56458ca5b7a3be25f42666b9eb050/src/core/ComponentModel/Common/CategoryNameAttribute.cs)*