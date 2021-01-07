# InnerJoin constructor (1 of 2)
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Data](../../README.md)*

Initializes a new instance of the [`InnerJoin`](../InnerJoin.md) class.

```csharp
public InnerJoin(string toTable, string alias, ICriteria onCriteria)
```

| parameter | description |
| --- | --- |
| toTable | To table. |
| alias | The alias. |
| onCriteria | The ON criteria. |

## See Also

* interface [ICriteria](../../Serenity/ICriteria.md)
* class [InnerJoin](../InnerJoin.md)

---

# InnerJoin constructor (2 of 2)
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Data](../../README.md)*

Initializes a new instance of the [`InnerJoin`](../InnerJoin.md) class.

```csharp
public InnerJoin(IDictionary<string, Join> joins, string toTable, string alias, 
    ICriteria onCriteria)
```

| parameter | description |
| --- | --- |
| joins | The joins. |
| toTable | To table. |
| alias | The alias. |
| onCriteria | The ON criteria. |

## See Also

* class [Join](../Join.md)
* interface [ICriteria](../../Serenity/ICriteria.md)
* class [InnerJoin](../InnerJoin.md)