# SqlQuery.LeftJoin method (1 of 2)

Adds a LEFT JOIN to the query

```csharp
public SqlQuery LeftJoin(IAlias alias, ICriteria onCriteria)
```

| parameter | description |
| --- | --- |
| alias | The alias. |
| onCriteria | The on criteria. |

## Return Value

The query itself.

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | alias is null. |
| ArgumentException | alias has no table name. |

## See Also

* interface [IAlias](../IAlias.md)
* interface [ICriteria](../../Serenity/ICriteria.md)
* class [SqlQuery](../SqlQuery.md)

---

# SqlQuery.LeftJoin method (2 of 2)

Adds a LEFT JOIN to the query.

```csharp
public SqlQuery LeftJoin(string toTable, IAlias alias, ICriteria onCriteria)
```

| parameter | description |
| --- | --- |
| toTable | To table. |
| alias | The alias. |
| onCriteria | The on criteria. |

## Return Value

The query itself.

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | alias or toTable is null. |
| ArgumentException | toTable is empty. |

## See Also

* interface [IAlias](../IAlias.md)
* interface [ICriteria](../../Serenity/ICriteria.md)
* class [SqlQuery](../SqlQuery.md)