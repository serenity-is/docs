# DefaultSqlConnections.WrapConnection method
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Data](../../README.md)*

Wraps and profiles the actual connection

```csharp
protected virtual IDbConnection WrapConnection(IDbConnection connection, string providerName, 
    ISqlDialect dialect)
```

| parameter | description |
| --- | --- |
| connection | Actual connection |
| providerName | Provider name |
| dialect | Dialect |

## See Also

* interface [ISqlDialect](../ISqlDialect.md)
* class [DefaultSqlConnections](../DefaultSqlConnections.md)