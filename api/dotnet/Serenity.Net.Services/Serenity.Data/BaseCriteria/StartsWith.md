# BaseCriteria.StartsWith method
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Creates a new binary Stars With (LIKE '...%') criteria containing this criteria as the left operand.

```csharp
public BaseCriteria StartsWith(string mask, bool upper = false)
```

| parameter | description |
| --- | --- |
| mask | The starts with mask. |
| upper | True to use UPPER function both sides |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | mask is null |

## See Also

* class [BaseCriteria](../BaseCriteria.md)