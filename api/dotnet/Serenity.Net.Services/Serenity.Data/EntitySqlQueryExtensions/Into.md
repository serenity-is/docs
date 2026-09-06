# EntitySqlQueryExtensions.Into method

Adds the specified entity to the INTO list of the query, and sets it as the current INTO row.

```csharp
public static SqlQuery Into(this SqlQuery query, IEntity into)
```

| parameter | description |
| --- | --- |
| query | The query. |
| into | The into. |

## Return Value

The query itself.

## See Also

* class [SqlQuery](../SqlQuery.md)
* interface [IEntity](../IEntity.md)
* class [EntitySqlQueryExtensions](../EntitySqlQueryExtensions.md)