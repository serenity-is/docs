# BaseCriteria.Like method

Creates a new binary Like criteria containing this criteria as the left operand. The mask is a raw LIKE pattern: %, _ and [...] act as wildcards and are not escaped. For literal values see [`Contains`](./Contains.md), [`StartsWith`](./StartsWith.md) or [`EndsWith`](./EndsWith.md).

```csharp
public BaseCriteria Like(string mask, bool upper = false)
```

| parameter | description |
| --- | --- |
| mask | The raw LIKE pattern. |
| upper | `true` to use the UPPER function on both sides. |

## Return Value

A new binary Like criteria.

## See Also

* class [BaseCriteria](../BaseCriteria.md)