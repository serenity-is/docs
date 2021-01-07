# BinaryCriteria class
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Data](../README.md)*

Binary criteria object, which has two operands and a operator.

```csharp
public class BinaryCriteria : BaseCriteria
```

## Public Members

| name | description |
| --- | --- |
| [BinaryCriteria](BinaryCriteria/BinaryCriteria.md)(…) | Initializes a new instance of the [`BinaryCriteria`](BinaryCriteria.md) class. |
| [LeftOperand](BinaryCriteria/LeftOperand.md) { get; } | Gets the left operand. |
| [Operator](BinaryCriteria/Operator.md) { get; } | Gets the operator. |
| [RightOperand](BinaryCriteria/RightOperand.md) { get; } | Gets the right operand. |
| override [ToString](BinaryCriteria/ToString.md)(…) | Converts the criteria to string in a string builder, while adding its params to the target query. |

## See Also

* class [BaseCriteria](BaseCriteria.md)
* **Source:** *[BinaryCriteria.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Data/Criteria/BinaryCriteria.cs)*