# GroupOrderAttribute class
**namespace:** *[Serenity.ComponentModel](../README.md#serenity.componentmodel-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Sets the order in which this property is grouped by default. This is only meaningful when a grid has grouping, and it sets the default grouped columns. The properties with this attribute are the default ones grouped by and their groupOrder determines in which order they are grouped.

```csharp
[AttributeUsage(AttributeTargets.All)]
public class GroupOrderAttribute : Attribute
```

| parameter | description |
| --- | --- |
| groupOrder | The group order. |

## Public Members

| name | description |
| --- | --- |
| [GroupOrderAttribute](GroupOrderAttribute/GroupOrderAttribute.md)(…) | Sets the order in which this property is grouped by default. This is only meaningful when a grid has grouping, and it sets the default grouped columns. The properties with this attribute are the default ones grouped by and their groupOrder determines in which order they are grouped. |
| [GroupOrder](GroupOrderAttribute/GroupOrder.md) { get; } | Gets the group order. |

## Remarks

Initializes a new instance of the [`GroupOrderAttribute`](GroupOrderAttribute.md) class.

## See Also

* **Source:** *[GroupOrderAttribute.cs](https://github.com/serenity-is/Serenity/blob/master/src/Core/ComponentModel/PropertyGrid/GroupOrderAttribute.cs)*