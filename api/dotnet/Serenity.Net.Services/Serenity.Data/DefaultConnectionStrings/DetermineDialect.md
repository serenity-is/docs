# DefaultConnectionStrings.DetermineDialect method

Determines the dialect for a connection.

```csharp
protected virtual ISqlDialect DetermineDialect(string connectionKey, ConnectionStringEntry entry)
```

| parameter | description |
| --- | --- |
| connectionKey | The connection key. |
| entry | The connection entry. |

## Return Value

The SQL dialect.

## See Also

* interface [ISqlDialect](../ISqlDialect.md)
* class [ConnectionStringEntry](../ConnectionStringEntry.md)
* class [DefaultConnectionStrings](../DefaultConnectionStrings.md)