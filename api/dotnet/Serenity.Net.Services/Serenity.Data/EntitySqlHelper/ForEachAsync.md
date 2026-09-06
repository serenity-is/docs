# EntitySqlHelper.ForEachAsync method (1 of 2)
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Asynchronously executes the specified callback for all rows returned from executing the query.

```csharp
public static Task<int> ForEachAsync(this SqlQuery query, IDbConnection connection, 
    Action callBack, CancellationToken cancellationToken = default(CancellationToken))
```

| parameter | description |
| --- | --- |
| query | The query. |
| connection | The connection. |
| callBack | The call back. |
| cancellationToken | The cancellation token. |

## Return Value

A task representing the asynchronous operation. The task result is the number of returned results.

## See Also

* class [SqlQuery](../SqlQuery.md)
* class [EntitySqlHelper](../EntitySqlHelper.md)

---

# EntitySqlHelper.ForEachAsync method (2 of 2)
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Asynchronously executes the specified data reader callback for all rows returned from executing the query.

```csharp
public static Task<int> ForEachAsync(this SqlQuery query, IDbConnection connection, 
    Action<IDataReader> callback, CancellationToken cancellationToken = default(CancellationToken))
```

| parameter | description |
| --- | --- |
| query | The query. |
| connection | The connection. |
| callback | The call back. |
| cancellationToken | The cancellation token. |

## Return Value

A task representing the asynchronous operation. The task result is the number of returned results.

## See Also

* class [SqlQuery](../SqlQuery.md)
* class [EntitySqlHelper](../EntitySqlHelper.md)