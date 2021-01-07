# SqlQuery.LeftJoin method (1 of 2)
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Data](../../README.md)*

Adds a LEFT JOIN to the query

```csharp
public SqlQuery LeftJoin(IAlias alias, ICriteria onCriteria)
```

| parameter | description |
| --- | --- |
| alias | The alias. |
| onCriteria | The on criteria. |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | alias is null or alias.table is null or empty. |

## See Also

* interface [IAlias](../IAlias.md)
* interface [ICriteria](../../Serenity/ICriteria.md)
* class [SqlQuery](../SqlQuery.md)

---

# SqlQuery.LeftJoin method (2 of 2)
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Data](../../README.md)*

Adds a LEFT JOIN to the query.

```csharp
public SqlQuery LeftJoin(string toTable, IAlias alias, ICriteria onCriteria)
```

| parameter | description |
| --- | --- |
| toTable | To table. |
| alias | The alias. |
| onCriteria | The on criteria. |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | alias is null or alias.table is null or empty |

## See Also

* interface [IAlias](../IAlias.md)
* interface [ICriteria](../../Serenity/ICriteria.md)
* class [SqlQuery](../SqlQuery.md)