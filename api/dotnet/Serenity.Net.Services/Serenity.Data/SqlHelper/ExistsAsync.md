# SqlHelper.ExistsAsync method

Executes the query asynchronously returning true if it has at least one result.

```csharp
public static Task<bool> ExistsAsync(this SqlQuery query, IDbConnection connection, 
    ILogger logger = null, CancellationToken cancellationToken = default)
```

| parameter | description |
| --- | --- |
| query | The query. |
| connection | The connection. |
| logger | The logger. |
| cancellationToken | The cancellation token. |

## Return Value

A task that represents the asynchronous operation. The task result is true if the query returns at least one result.

## See Also

* class [SqlQuery](../SqlQuery.md)
* class [SqlHelper](../SqlHelper.md)