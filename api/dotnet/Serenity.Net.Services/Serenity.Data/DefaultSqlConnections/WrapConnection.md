# DefaultSqlConnections.WrapConnection method

Wraps and profiles the actual connection.

```csharp
protected virtual IDbConnection WrapConnection(IDbConnection connection, string providerName, 
    ISqlDialect dialect)
```

| parameter | description |
| --- | --- |
| connection | The actual connection. |
| providerName | The provider name. |
| dialect | The dialect. |

## Return Value

The wrapped connection.

## See Also

* interface [ISqlDialect](../ISqlDialect.md)
* class [DefaultSqlConnections](../DefaultSqlConnections.md)