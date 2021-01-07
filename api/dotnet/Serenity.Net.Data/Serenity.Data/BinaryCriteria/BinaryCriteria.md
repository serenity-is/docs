# BinaryCriteria constructor
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Data](../../README.md)*

Initializes a new instance of the [`BinaryCriteria`](../BinaryCriteria.md) class.

```csharp
public BinaryCriteria(BaseCriteria left, CriteriaOperator op, BaseCriteria right)
```

| parameter | description |
| --- | --- |
| left | The left operand. |
| op | The operator. |
| right | The right operand. |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | Left or right operand is null. |
| ArgumentOutOfRangeException | Operator is not a binary one. |

## See Also

* class [BaseCriteria](../BaseCriteria.md)
* enum [CriteriaOperator](../CriteriaOperator.md)
* class [BinaryCriteria](../BinaryCriteria.md)