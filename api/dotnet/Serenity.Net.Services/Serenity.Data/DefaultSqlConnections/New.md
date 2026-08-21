# DefaultSqlConnections.New method
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Creates a new IDbConnection for the given connection string, provider name, and dialect.

```csharp
public virtual IDbConnection New(string connectionString, string providerName, ISqlDialect dialect)
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