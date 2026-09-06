# SqlQuery.InnerJoin method

Adds an inner join to the query.

```csharp
public SqlQuery InnerJoin(IAlias alias, ICriteria onCriteria)
```

| parameter | description |
| --- | --- |
| alias | The alias. |
| onCriteria | The ON criteria. |

## Return Value

The query itself.

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | alias is null or alias.table is null |

## See Also

* interface [IAlias](../IAlias.md)
* interface [ICriteria](../../Serenity/ICriteria.md)
* class [SqlQuery](../SqlQuery.md)