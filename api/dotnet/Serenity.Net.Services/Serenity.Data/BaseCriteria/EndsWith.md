# BaseCriteria.EndsWith method
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Creates a new binary Ends With (LIKE '%...') criteria containing this criteria as the left operand.

```csharp
public BaseCriteria EndsWith(string mask, bool upper = false)
```

| parameter | description |
| --- | --- |
| mask | The ends with mask. |
| upper | `true` to use the UPPER function on both sides. |

## Return Value

A new binary Ends With criteria.

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | mask is null |

## See Also

* class [BaseCriteria](../BaseCriteria.md)