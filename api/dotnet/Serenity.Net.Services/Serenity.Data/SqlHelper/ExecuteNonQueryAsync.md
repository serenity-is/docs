# SqlHelper.ExecuteNonQueryAsync method
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Executes the statement asynchronously.

```csharp
public static Task<int> ExecuteNonQueryAsync(IDbConnection connection, string commandText, 
    IDictionary<string, object> param = null, ILogger logger = null, 
    CancellationToken cancellationToken = default(CancellationToken))
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