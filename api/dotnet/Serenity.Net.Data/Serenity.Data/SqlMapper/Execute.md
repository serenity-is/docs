# SqlMapper.Execute method
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Data](../../README.md)*

Execute parameterized SQL

```csharp
public static int Execute(this IDbConnection cnn, string sql, object param = null, 
    IDbTransaction transaction = null, int? commandTimeout = null, 
    CommandType? commandType = default(CommandType?))
```

| parameter | description |
| --- | --- |
| cnn | Connection. |
| sql | SQL query. |
| param | The parameters. |
| transaction | The transaction. |
| commandTimeout | The command timeout. |
| commandType | Type of the command. |

## Return Value

Number of rows affected

## See Also

* class [SqlMapper](../SqlMapper.md)