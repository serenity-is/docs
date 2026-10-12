# ConnectionExtensions.EnsureOpen method

Ensures the connection is open. Warning! This method will not reopen a connection that was once opened and will raise an error. Reopening onto a fresh session while a (possibly stale, post-close) transaction reference remains would enlist later commands in a dead transaction, so reuse after close is refused instead of silently allowed.

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