# EntitySqlHelper.ForEach method (1 of 2)
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Executes the specified callback for all rows returned from executing the query.

```csharp
public static int ForEach(this SqlQuery query, IDbConnection connection, Action callBack)
```

| parameter | description |
| --- | --- |
| query | The query. |
| connection | The connection. |
| callBack | The call back. |

## Return Value

Number of returned results.

## See Also

* class [SqlQuery](../SqlQuery.md)
* class [EntitySqlHelper](../EntitySqlHelper.md)

---

# EntitySqlHelper.ForEach method (2 of 2)
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Executes the specified data reader callback for all rows returned from executing the query.

```csharp
public static int ForEach(this SqlQuery query, IDbConnection connection, 
    Action<IDataReader> callback)
```

| parameter | description |
| --- | --- |
| query | The query. |
| connection | The connection. |
| callback | The call back. |

## Return Value

Number of returned results

## See Also

* class [SqlQuery](../SqlQuery.md)
* class [EntitySqlHelper](../EntitySqlHelper.md)