# ConnectionExtensions.GetLogger method
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Data](../../README.md)*

Gets the logger for a connection if it implements IHasLogger interface, or null if not.

```csharp
public static ILogger GetLogger(this IDbConnection connection)
```

| parameter | description |
| --- | --- |
| connection | The connection. |

## Return Value

The logger for connection (used by static SqlHelper methods)

## See Also

* class [ConnectionExtensions](../ConnectionExtensions.md)