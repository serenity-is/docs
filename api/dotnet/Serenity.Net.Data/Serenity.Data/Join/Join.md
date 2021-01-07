# Join constructor
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Data](../../README.md)*

Initializes a new instance of the [`Join`](../Join.md) class.

```csharp
protected Join(IDictionary<string, Join> joins, string toTable, string alias, ICriteria onCriteria)
```

| parameter | description |
| --- | --- |
| joins | The joins dictionary. |
| toTable | To table. |
| alias | The alias. |
| onCriteria | The ON criteria. |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentException |  |

## See Also

* interface [ICriteria](../../Serenity/ICriteria.md)
* class [Join](../Join.md)