# SortOrderAttribute class
**namespace:** *[Serenity.ComponentModel](../README.md#serenity.componentmodel-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Sets the column as sorted by default, and its index among sorted columns. Negative values means descending sort. Applies only to columns.

```csharp
[AttributeUsage(AttributeTargets.All)]
public class SortOrderAttribute : Attribute
```

## Public Members

| name | description |
| --- | --- |
| [SortOrderAttribute](SortOrderAttribute/SortOrderAttribute.md)(…) | Initializes a new instance of the [`SortOrderAttribute`](SortOrderAttribute.md) class. (2 constructors) |
| [Descending](SortOrderAttribute/Descending.md) { get; } | Gets a value indicating whether sort is descending. |
| [SortOrder](SortOrderAttribute/SortOrder.md) { get; } | Gets the sort order. |

## See Also

* **Source:** *[SortOrderAttribute.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Core/ComponentModel/PropertyGrid/SortOrderAttribute.cs)*