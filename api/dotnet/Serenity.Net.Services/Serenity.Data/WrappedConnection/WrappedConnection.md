# WrappedConnection constructor

Initializes a new instance of the [`WrappedConnection`](../WrappedConnection.md) class.

```csharp
public WrappedConnection(IDbConnection connection, ISqlDialect dialect, ILogger logger = null)
```

| parameter | description |
| --- | --- |
| connection | The actual connection. |
| dialect | The dialect. |
| logger | Optional logger for this connection (generally to be used by static SqlHelper methods) |

## See Also

* interface [ISqlDialect](../ISqlDialect.md)
* class [WrappedConnection](../WrappedConnection.md)