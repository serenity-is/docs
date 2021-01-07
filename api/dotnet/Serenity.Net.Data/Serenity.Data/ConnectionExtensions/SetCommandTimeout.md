# ConnectionExtensions.SetCommandTimeout method
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Data](../../README.md)*

Sets the default command timeout for given connection. Only works with IHasCommandTimeout (WrappedConnection) instances, which are usually created by SqlConnections.NewXyz methods.

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