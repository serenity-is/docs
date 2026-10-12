# BinaryCriteria class
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Binary criteria object, which has two operands and a operator.

```csharp
public class BinaryCriteria : BaseCriteria
```

## Public Members

| name | description |
| --- | --- |
| [BinaryCriteria](BinaryCriteria/BinaryCriteria.md)(…) | Initializes a new instance of the [`BinaryCriteria`](./BinaryCriteria.md) class. (2 constructors) |
| [LeftOperand](BinaryCriteria/LeftOperand.md) { get; } | Gets the left operand. |
| [LikeEscapeChar](BinaryCriteria/LikeEscapeChar.md) { get; } | Gets the LIKE escape character, or null when no ESCAPE clause is rendered. Only set for Like / NotLike operators. |
| [Operator](BinaryCriteria/Operator.md) { get; } | Gets the operator. |
| [RightOperand](BinaryCriteria/RightOperand.md) { get; } | Gets the right operand. |
| override [ToString](BinaryCriteria/ToString.md)(…) | Converts the criteria to string in a string builder, while adding its params to the target query. |

## See Also

* class [BaseCriteria](./BaseCriteria.md)
* **Source:** *[BinaryCriteria.cs](https://github.com/serenity-is/Serenity/blob/489f72f785a9733fa81e465e1a3854209296a6c0/src/services/Data/Criteria/BinaryCriteria.cs)*