# BinaryCriteria constructor (1 of 2)

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

---

# BinaryCriteria constructor (2 of 2)

Initializes a new instance of the [`BinaryCriteria`](../BinaryCriteria.md) class with a LIKE escape character.

```csharp
public BinaryCriteria(BaseCriteria left, CriteriaOperator op, BaseCriteria right, 
    char likeEscapeChar)
```

| parameter | description |
| --- | --- |
| left | The left operand. |
| op | The operator. Must be Like or NotLike when likeEscapeChar is set. |
| right | The right operand (the LIKE pattern). |
| likeEscapeChar | The LIKE escape character, appended as ESCAPE 'x'. Retained only when the pattern contains it; otherwise omitted as inert. |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | Left or right operand is null. |
| ArgumentOutOfRangeException | Operator is not a binary one. |
| ArgumentException | LikeEscapeChar is set with an operator other than Like / NotLike, or the escape character itself is a LIKE wildcard (%, _) or a quote. |

## See Also

* class [BaseCriteria](../BaseCriteria.md)
* enum [CriteriaOperator](../CriteriaOperator.md)
* class [BinaryCriteria](../BinaryCriteria.md)