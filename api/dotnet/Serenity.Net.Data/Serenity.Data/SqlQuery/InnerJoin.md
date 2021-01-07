# SqlQuery.InnerJoin method
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Data](../../README.md)*

Adds an inner join to the query.

```csharp
public SqlQuery InnerJoin(IAlias alias, ICriteria onCriteria)
```

| parameter | description |
| --- | --- |
| alias | The alias. |
| onCriteria | The ON criteria. |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | alias is null or alias.table is null |

## See Also

* interface [IAlias](../IAlias.md)
* interface [ICriteria](../../Serenity/ICriteria.md)
* class [SqlQuery](../SqlQuery.md)