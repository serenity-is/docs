# WrappedConnection constructor
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Wraps a connection to add current transaction and dialect support.

```csharp
public WrappedConnection(IDbConnection connection, ISqlDialect dialect, ILogger logger = null)
```

| parameter | description |
| --- | --- |
| connection | The actual connection. |
| dialect | The dialect. |
| logger | Optional logger for this connection (generally to be used by static SqlHelper methods) |

## Remarks

Initializes a new instance of the [`WrappedConnection`](../WrappedConnection.md) class.

## See Also

* interface [ISqlDialect](../ISqlDialect.md)
* class [WrappedConnection](../WrappedConnection.md)