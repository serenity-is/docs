# BaseCriteria.NotLike method

Creates a new binary Not Like criteria containing this criteria as the left operand. The mask is a raw LIKE pattern: %, _ and [...] act as wildcards and are not escaped. For literal values see [`NotContains`](./NotContains.md).

```csharp
public BaseCriteria NotLike(string mask, bool upper = false)
```

| parameter | description |
| --- | --- |
| mask | The raw like pattern. |
| upper | `true` to use the UPPER function on both sides. |

## Return Value

A new binary Not Like criteria.

## See Also

* class [BaseCriteria](../BaseCriteria.md)