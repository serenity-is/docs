# BaseCriteria.Like method

Creates a new binary Like criteria containing this criteria as the left operand.

```csharp
public BaseCriteria Like(string mask, bool upper = false)
```

| parameter | description |
| --- | --- |
| mask | The LIKE mask. |
| upper | `true` to use the UPPER function on both sides. |

## Return Value

A new binary Like criteria.

## See Also

* class [BaseCriteria](../BaseCriteria.md)