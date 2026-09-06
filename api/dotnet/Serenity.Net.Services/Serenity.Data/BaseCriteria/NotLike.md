# BaseCriteria.NotLike method

Creates a new binary Not Like criteria containing this criteria as the left operand.

```csharp
public BaseCriteria NotLike(string mask, bool upper = false)
```

| parameter | description |
| --- | --- |
| mask | The like mask. |
| upper | `true` to use the UPPER function on both sides. |

## Return Value

A new binary Not Like criteria.

## See Also

* class [BaseCriteria](../BaseCriteria.md)