# EditorFilteringAttribute class
**namespace:** *[Serenity.ComponentModel](../README.md#serenity.componentmodel-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Indicates that property should a custom editor for filtering, which is usually determined by form editor type of the property.

```csharp
[AttributeUsage(AttributeTargets.All)]
public class EditorFilteringAttribute : CustomFilteringAttribute
```

## Public Members

| name | description |
| --- | --- |
| [EditorFilteringAttribute](EditorFilteringAttribute/EditorFilteringAttribute.md)() | Initializes a new instance of the [`EditorFilteringAttribute`](EditorFilteringAttribute.md) class. |
| [EditorFilteringAttribute](EditorFilteringAttribute/EditorFilteringAttribute.md)(…) | Initializes a new instance of the [`EditorFilteringAttribute`](EditorFilteringAttribute.md) class. (2 constructors) |
| [EditorType](EditorFilteringAttribute/EditorType.md) { get; set; } | Gets or sets the type of the editor. |
| [UseLike](EditorFilteringAttribute/UseLike.md) { get; set; } | Gets or sets a value indicating whether to use LIKE kind of operators including starts with, ends with etc. |
| [UseRelative](EditorFilteringAttribute/UseRelative.md) { get; set; } | Gets or sets a value indicating whether to use relative comparisons, like GT/LT. |

## See Also

* class [CustomFilteringAttribute](CustomFilteringAttribute.md)
* **Source:** *[EditorFilteringAttribute.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Core/ComponentModel/Columns/Filtering/BasicFilteringTypes/EditorFilteringAttribute.cs)*