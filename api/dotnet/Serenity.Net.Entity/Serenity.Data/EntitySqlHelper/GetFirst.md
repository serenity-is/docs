# EntitySqlHelper.GetFirst method (1 of 2)
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Entity](../../README.md)*

Gets the first entity returned by executing the query. The result is loaded into the loader row of the query.

```csharp
public static bool GetFirst(this SqlQuery query, IDbConnection connection)
```

| parameter | description |
| --- | --- |
| query | The query. |
| connection | The connection. |

## Return Value

True if any rows returned

## See Also

* class [SqlQuery](../Serenity.Net.Data/../SqlQuery.md)
* class [EntitySqlHelper](../EntitySqlHelper.md)

---

# EntitySqlHelper.GetFirst method (2 of 2)
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Entity](../../README.md)*

Gets the first entity returned by executing the query into the specified row.

```csharp
public static bool GetFirst(this SqlQuery query, IDbConnection connection, IEntity row, 
    Dictionary<string, object> param)
```

| parameter | description |
| --- | --- |
| query | The query. |
| connection | The connection. |
| row | The row. |
| param | The parameter dictionary. |

## Return Value

True if any results returned from reader.

## See Also

* class [SqlQuery](../Serenity.Net.Data/../SqlQuery.md)
* interface [IEntity](../IEntity.md)
* class [EntitySqlHelper](../EntitySqlHelper.md)