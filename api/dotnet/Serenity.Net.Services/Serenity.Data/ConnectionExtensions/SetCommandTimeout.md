# ConnectionExtensions.SetCommandTimeout method

Sets the default command timeout for the given connection. Only works with [`IHasCommandTimeout`](../IHasCommandTimeout.md) ([`WrappedConnection`](../WrappedConnection.md)) instances, which are usually created by SqlConnections.NewXyz methods.

```csharp
public static void SetCommandTimeout(this IDbConnection connection, int? timeout)
```

| parameter | description |
| --- | --- |
| connection | The connection. |
| timeout | The timeout value. |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentOutOfRangeException | Connection is not a WrappedConnection. |

## See Also

* class [ConnectionExtensions](../ConnectionExtensions.md)