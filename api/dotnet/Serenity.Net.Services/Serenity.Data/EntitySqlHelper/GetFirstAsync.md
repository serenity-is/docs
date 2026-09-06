# EntitySqlHelper.GetFirstAsync method
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Gets the first entity returned by executing the query asynchronously. The result is loaded into the loader row of the query.

```csharp
public static Task<bool> GetFirstAsync(this SqlQuery query, IDbConnection connection, 
    CancellationToken cancellationToken = default(CancellationToken))
```

| parameter | description |
| --- | --- |
| query | The query. |
| connection | The connection. |
| cancellationToken | The cancellation token. |

## Return Value

A task that represents the asynchronous operation. The task result is true if any rows were returned.

## See Also

* class [SqlQuery](../SqlQuery.md)
* class [EntitySqlHelper](../EntitySqlHelper.md)