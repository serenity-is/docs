# BaseCriteria.Contains method
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Creates a new binary Contains criteria (LIKE '%...%') containing this criteria as the left operand.

```csharp
public BaseCriteria Contains(string mask, bool upper = false)
```

| parameter | description |
| --- | --- |
| mask | The contains mask. |
| upper | `true` to use the UPPER function on both sides. |

## Return Value

A new binary Contains criteria.

## See Also

* class [BaseCriteria](../BaseCriteria.md)