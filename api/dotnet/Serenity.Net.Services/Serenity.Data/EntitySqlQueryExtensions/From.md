# EntitySqlQueryExtensions.From method

Adds a table to the FROM statement with "T0" alias and sets it as the target for future field selections.

```csharp
public static SqlQuery From(this SqlQuery query, IEntity entity)
```

| parameter | description |
| --- | --- |
| query | The query. |
| entity | The entity. |

## Return Value

The query itself.

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | entity is null. |

## See Also

* class [SqlQuery](../SqlQuery.md)
* interface [IEntity](../IEntity.md)
* class [EntitySqlQueryExtensions](../EntitySqlQueryExtensions.md)