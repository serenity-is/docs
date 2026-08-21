# BaseCriteria.StartsWith method
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Creates a new binary Starts With (LIKE '...%') criteria containing this criteria as the left operand.

```csharp
public BaseCriteria StartsWith(string mask, bool upper = false)
```

| parameter | description |
| --- | --- |
| mask | The starts with mask. |
| upper | `true` to use the UPPER function on both sides. |

## Return Value

A new binary Starts With criteria.

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | mask is null |

## See Also

* class [BaseCriteria](../BaseCriteria.md)