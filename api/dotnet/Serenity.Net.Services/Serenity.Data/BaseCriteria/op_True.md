# BaseCriteria True operator

Returns false so that `&&` evaluates its right operand and combines both criteria with [`operator &amp;`](./op_BitwiseAnd.md).

```csharp
public static bool operator true(BaseCriteria statement)
```

## Remarks

Criteria are SQL expression builders, not Boolean values. This operator always returns false; do not use a criteria in a Boolean conditional.

## See Also

* class [BaseCriteria](../BaseCriteria.md)