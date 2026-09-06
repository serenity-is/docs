# ConnectionExtensions.EnsureOpenAsync method

Ensures the connection is open asynchronously. Warning! This method will not reopen a connection that was once opened and will raise an error.

```csharp
public static Task<IDbConnection> EnsureOpenAsync(this IDbConnection connection, 
    CancellationToken cancellationToken = default)
```

| parameter | description |
| --- | --- |
| connection | The connection. |
| cancellationToken | The cancellation token. |

## Return Value

A task that represents the asynchronous operation. The task result contains the connection.

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | connection |
| InvalidOperationException | Can't auto open a closed connection that was previously open! |

## See Also

* class [ConnectionExtensions](../ConnectionExtensions.md)