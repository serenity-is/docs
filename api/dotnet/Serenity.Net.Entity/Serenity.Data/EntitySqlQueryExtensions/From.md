# EntitySqlQueryExtensions.From method
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Entity](../../README.md)*

Adds a table to the FROM statement with "T0" alias and sets it as target for future field selections.

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
| ArgumentNullException | row |

## See Also

* class [SqlQuery](../Serenity.Net.Data/../SqlQuery.md)
* interface [IEntity](../IEntity.md)
* class [EntitySqlQueryExtensions](../EntitySqlQueryExtensions.md)