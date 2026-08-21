# ConnectionExtensions.EnsureOpen method
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Ensures the connection is open. Warning! This method will not reopen a connection that was once opened and will raise an error.

```csharp
public static IDbConnection EnsureOpen(this IDbConnection connection)
```

| parameter | description |
| --- | --- |
| connection | The connection. |

## Return Value

The connection.

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | connection |
| InvalidOperationException | Can't auto open a closed connection that was previously open! |

## See Also

* class [ConnectionExtensions](../ConnectionExtensions.md)