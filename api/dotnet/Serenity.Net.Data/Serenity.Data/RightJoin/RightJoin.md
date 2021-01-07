# RightJoin constructor (1 of 2)
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Data](../../README.md)*

Initializes a new instance of the [`RightJoin`](../RightJoin.md) class.

```csharp
public RightJoin(string toTable, string alias, ICriteria onCriteria)
```

| parameter | description |
| --- | --- |
| toTable | To table. |
| alias | The alias. |
| onCriteria | The ON criteria. |

## See Also

* interface [ICriteria](../../Serenity/ICriteria.md)
* class [RightJoin](../RightJoin.md)

---

# RightJoin constructor (2 of 2)
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Data](../../README.md)*

Initializes a new instance of the [`RightJoin`](../RightJoin.md) class.

```csharp
public RightJoin(IDictionary<string, Join> joins, string toTable, string alias, 
    ICriteria onCriteria)
```

| parameter | description |
| --- | --- |
| joins | The joins dictionary. |
| toTable | To table. |
| alias | The alias. |
| onCriteria | The ON criteria. |

## See Also

* class [Join](../Join.md)
* interface [ICriteria](../../Serenity/ICriteria.md)
* class [RightJoin](../RightJoin.md)