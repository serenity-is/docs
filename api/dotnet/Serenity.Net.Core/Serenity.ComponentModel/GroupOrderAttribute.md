# GroupOrderAttribute class
**namespace:** *[Serenity.ComponentModel](../README.md#serenity.componentmodel-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Sets in which order this property should be grouped by. This is only meaningful when a grid has grouping, and it sets the default grouped columns. The properties with this attribute are the default ones grouped by and their groupOrder determines in which order they are grouped by.

```csharp
[AttributeUsage(AttributeTargets.All)]
public class GroupOrderAttribute : Attribute
```

## Public Members

| name | description |
| --- | --- |
| [GroupOrderAttribute](GroupOrderAttribute/GroupOrderAttribute.md)(…) | Initializes a new instance of the [`GroupOrderAttribute`](GroupOrderAttribute.md) class. |
| [GroupOrder](GroupOrderAttribute/GroupOrder.md) { get; } | Gets the group order. |

## See Also

* **Source:** *[GroupOrderAttribute.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Core/ComponentModel/PropertyGrid/GroupOrderAttribute.cs)*