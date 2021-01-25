# EntitySqlHelper.GetSingle method (1 of 2)
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Entity](../../README.md)*

Gets the single entity returned by executing the query. The values are loaded into the loader row of the query.

```csharp
public static bool GetSingle(this SqlQuery query, IDbConnection connection)
```

| parameter | description |
| --- | --- |
| query | The query. |
| connection | The connection. |

## Return Value

True if any results returned from data reader

## Exceptions

| exception | condition |
| --- | --- |
| InvalidOperationException | Query returned more than one result! |

## See Also

* class [SqlQuery](../Serenity.Net.Data/../SqlQuery.md)
* class [EntitySqlHelper](../EntitySqlHelper.md)

---

# EntitySqlHelper.GetSingle method (2 of 2)
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Entity](../../README.md)*

Gets the single entity returned by executing the query into the specified row.

```csharp
public static bool GetSingle(this SqlQuery query, IDbConnection connection, IRow row, 
    Dictionary<string, object> param)
```

| parameter | description |
| --- | --- |
| query | The query. |
| connection | The connection. |
| row | The row to load data into. |
| param | The parameter. |

## Return Value

True if one result

## Exceptions

| exception | condition |
| --- | --- |
| InvalidOperationException | Query returned more than one result! |

## See Also

* class [SqlQuery](../Serenity.Net.Data/../SqlQuery.md)
* interface [IRow](../IRow.md)
* class [EntitySqlHelper](../EntitySqlHelper.md)