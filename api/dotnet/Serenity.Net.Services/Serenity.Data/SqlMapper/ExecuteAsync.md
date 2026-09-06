# SqlMapper.ExecuteAsync method

Executes a parameterized SQL statement asynchronously.

```csharp
public static Task<int> ExecuteAsync(this IDbConnection cnn, string sql, object param = null, 
    IDbTransaction transaction = null, int? commandTimeout = null, 
    CommandType? commandType = default, CancellationToken cancellationToken = default)
```

| parameter | description |
| --- | --- |
| cnn | The connection. |
| sql | The SQL query. |
| param | The parameters. |
| transaction | The transaction. |
| commandTimeout | The command timeout. |
| commandType | Type of the command. |
| cancellationToken | The cancellation token. |

## Return Value

A task that represents the asynchronous operation. The task result contains the number of rows affected.

## See Also

* class [SqlMapper](../SqlMapper.md)