# BaseCriteria.NotContains method

Creates a new binary Not Contains criteria (NOT LIKE '%...%') containing this criteria as the left operand.

```csharp
public BaseCriteria NotContains(string mask, bool upper = false)
```

| parameter | description |
| --- | --- |
| mask | The contains mask. |
| upper | `true` to use the UPPER function on both sides. |

## Return Value

A new binary Not Contains criteria.

## See Also

* class [BaseCriteria](../BaseCriteria.md)