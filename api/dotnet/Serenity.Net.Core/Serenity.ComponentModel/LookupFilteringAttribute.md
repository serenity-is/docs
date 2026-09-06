# LookupFilteringAttribute class
**namespace:** *[Serenity.ComponentModel](../README.md#serenity.componentmodel-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Indicates that the property should use lookup editor type of filtering.

```csharp
[AttributeUsage(AttributeTargets.All)]
public class LookupFilteringAttribute : CustomFilteringAttribute
```

## Public Members

| name | description |
| --- | --- |
| [LookupFilteringAttribute](LookupFilteringAttribute/LookupFilteringAttribute.md)(…) | Initializes a new instance of the [`LookupFilteringAttribute`](./LookupFilteringAttribute.md) class. (2 constructors) |
| [IdField](LookupFilteringAttribute/IdField.md) { get; set; } | Gets or sets the ID field that the editor should filter on. |
| [LookupKey](LookupFilteringAttribute/LookupKey.md) { get; } | Gets the lookup key |
| const [Key](LookupFilteringAttribute/Key.md) | Filtering type key |

## See Also

* class [CustomFilteringAttribute](./CustomFilteringAttribute.md)
* **Source:** *[LookupFilteringAttribute.cs](https://github.com/serenity-is/Serenity/blob/a5013fdf777dbbd87589205ddffcb67f18bea673/src/core/ComponentModel/Columns/Filtering/BasicFilteringTypes/LookupFilteringAttribute.cs)*