# EditorFilteringAttribute class
**namespace:** *[Serenity.ComponentModel](../README.md#serenity.componentmodel-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Indicates that the property should have a custom editor for filtering, which is usually determined by the form editor type of the property.

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
| [UseLike](EditorFilteringAttribute/UseLike.md) { get; set; } | Gets or sets a value indicating whether to use LIKE-style operators, including starts with, ends with, etc. |
| [UseRelative](EditorFilteringAttribute/UseRelative.md) { get; set; } | Gets or sets a value indicating whether to use relative comparisons, like GT/LT. |
| const [Key](EditorFilteringAttribute/Key.md) | Filtering type key |

## See Also

* class [CustomFilteringAttribute](CustomFilteringAttribute.md)
* **Source:** *[EditorFilteringAttribute.cs](https://github.com/serenity-is/Serenity/blob/a5013fdf777dbbd87589205ddffcb67f18bea673/src/core/ComponentModel/Columns/Filtering/BasicFilteringTypes/EditorFilteringAttribute.cs)*