# SqlHelper.ExecuteNonQueryAsync method

Executes the statement asynchronously.

```csharp
public static Task<int> ExecuteNonQueryAsync(IDbConnection connection, string commandText, 
    IDictionary<string, object> param = null, ILogger logger = null, 
    CancellationToken cancellationToken = default)
```

| parameter | description |
| --- | --- |
| connection | The connection. |
| commandText | The command text. |
| param | The parameters. |
| logger | The logger. |
| cancellationToken | The cancellation token. |

## Return Value

A task that represents the asynchronous operation. The task result contains the number of affected rows.

## See Also

* class [SqlHelper](../SqlHelper.md)