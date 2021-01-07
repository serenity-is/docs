# ISqlConnections.New method
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Data](../../README.md)*

Creates a new IDbConnection for given connection string, provider name and dialect.

```csharp
public IDbConnection New(string connectionString, string providerName, ISqlDialect dialect)
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
* interface [ISqlConnections](../ISqlConnections.md)