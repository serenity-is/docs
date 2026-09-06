# DefaultSqlConnections.TryGetConnectionString method

Gets a connection string by its key.

```csharp
public virtual IConnectionString TryGetConnectionString(string connectionKey)
```

| parameter | description |
| --- | --- |
| connectionKey | The connection key. |

## Return Value

The connection string, or `null` if not found.

## See Also

* interface [IConnectionString](../IConnectionString.md)
* class [DefaultSqlConnections](../DefaultSqlConnections.md)