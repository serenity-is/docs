# SqlQuery.RightJoin method (1 of 2)
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Data](../../README.md)*

Adds a right join to the query.

```csharp
public SqlQuery RightJoin(IAlias alias, ICriteria onCriteria)
```

| parameter | description |
| --- | --- |
| alias | The alias with table name/alias name. |
| onCriteria | The ON criteria. |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | alias is null or alias.table is null |

## See Also

* interface [IAlias](../IAlias.md)
* interface [ICriteria](../../Serenity/ICriteria.md)
* class [SqlQuery](../SqlQuery.md)

---

# SqlQuery.RightJoin method (2 of 2)
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Data](../../README.md)*

Adds a right join to the query.

```csharp
public SqlQuery RightJoin(string toTable, IAlias alias, ICriteria onCriteria)
```

| parameter | description |
| --- | --- |
| toTable | Right join to table. |
| alias | The alias. |
| onCriteria | The on criteria. |

## Return Value

SqlQuery itself.

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | alias is null or alias.table is null |

## See Also

* interface [IAlias](../IAlias.md)
* interface [ICriteria](../../Serenity/ICriteria.md)
* class [SqlQuery](../SqlQuery.md)