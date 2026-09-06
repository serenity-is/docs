# ConnectionExtensions.GetLogger method

Gets the logger for a connection if it implements the [`IHasLogger`](../IHasLogger.md) interface, or `null` if not.

```csharp
public static ILogger GetLogger(this IDbConnection connection)
```

| parameter | description |
| --- | --- |
| connection | The connection. |

## Return Value

The logger for the connection (used by static SqlHelper methods).

## See Also

* class [ConnectionExtensions](../ConnectionExtensions.md)