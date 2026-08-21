# DefaultSqlConnections.CreateConnection method
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Creates an actual connection based on the provider name. This should not return a wrapped connection.

```csharp
protected virtual IDbConnection CreateConnection(string connectionString, string providerName, 
    ISqlDialect dialect)
```

| parameter | description |
| --- | --- |
| connectionString | The connection string. |
| providerName | The provider name. |
| dialect | The dialect. |

## Return Value

A new IDbConnection object.

## See Also

* interface [ISqlDialect](../ISqlDialect.md)
* class [DefaultSqlConnections](../DefaultSqlConnections.md)