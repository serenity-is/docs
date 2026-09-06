# EntitySqlHelper.GetSingleAsync method

Gets the single entity returned by executing the query asynchronously. The values are loaded into the loader row of the query.

```csharp
public static Task<bool> GetSingleAsync(this SqlQuery query, IDbConnection connection, 
    CancellationToken cancellationToken = default)
```

| parameter | description |
| --- | --- |
| query | The query. |
| connection | The connection. |
| cancellationToken | The cancellation token. |

## Return Value

A task that represents the asynchronous operation. The task result is true if any results were returned from the data reader.

## Exceptions

| exception | condition |
| --- | --- |
| InvalidOperationException | Query returned more than one result! |

## See Also

* class [SqlQuery](../SqlQuery.md)
* class [EntitySqlHelper](../EntitySqlHelper.md)