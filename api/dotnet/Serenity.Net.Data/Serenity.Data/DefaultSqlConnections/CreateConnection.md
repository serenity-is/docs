# DefaultSqlConnections.CreateConnection method
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Data](../../README.md)*

Creates an actual connection based on providerName, this should not return a wrapped connection.

```csharp
protected virtual IDbConnection CreateConnection(string connectionString, string providerName, 
    ISqlDialect dialect)
```

| parameter | description |
| --- | --- |
| connectionString | Connection string |
| providerName | Provider name |
| dialect | Dialect |

## Return Value

A new IDbConnection object.

## See Also

* interface [ISqlDialect](../ISqlDialect.md)
* class [DefaultSqlConnections](../DefaultSqlConnections.md)