# SqlMapper.Execute method
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Executes a parameterized SQL statement.

```csharp
public static int Execute(this IDbConnection cnn, string sql, object param = null, 
    IDbTransaction transaction = null, int? commandTimeout = null, 
    CommandType? commandType = default(CommandType?))
```

| parameter | description |
| --- | --- |
| cnn | The connection. |
| sql | The SQL query. |
| param | The parameters. |
| transaction | The transaction. |
| commandTimeout | The command timeout. |
| commandType | Type of the command. |

## Return Value

The number of rows affected.

## See Also

* class [SqlMapper](../SqlMapper.md)