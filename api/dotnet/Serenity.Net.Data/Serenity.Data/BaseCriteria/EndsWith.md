# BaseCriteria.EndsWith method
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Data](../../README.md)*

Creates a new binary Ends With (LIKE '%...') criteria containing this criteria as the left operand.

```csharp
public BaseCriteria EndsWith(string mask)
```

| parameter | description |
| --- | --- |
| mask | The ends with mask. |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | mask is null |

## See Also

* class [BaseCriteria](../BaseCriteria.md)