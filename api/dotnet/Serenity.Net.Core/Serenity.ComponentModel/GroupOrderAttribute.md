# GroupOrderAttribute class
**namespace:** *[Serenity.ComponentModel](../README.md#serenity.componentmodel-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Sets in which order this property should be grouped by. This is only meaningful when a grid has grouping, and it sets the default grouped columns. The properties with this attribute are the default ones grouped by and their groupOrder determines in which order they are grouped by.

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
| [GroupOrderAttribute](GroupOrderAttribute/GroupOrderAttribute.md)(…) | Sets in which order this property should be grouped by. This is only meaningful when a grid has grouping, and it sets the default grouped columns. The properties with this attribute are the default ones grouped by and their groupOrder determines in which order they are grouped by. |
| [GroupOrder](GroupOrderAttribute/GroupOrder.md) { get; } | Gets the group order. |

## Remarks

Initializes a new instance of the [`GroupOrderAttribute`](GroupOrderAttribute.md) class.

## See Also

* **Source:** *[GroupOrderAttribute.cs](https://github.com/serenity-is/Serenity/blob/master/src/Core/ComponentModel/PropertyGrid/GroupOrderAttribute.cs)*