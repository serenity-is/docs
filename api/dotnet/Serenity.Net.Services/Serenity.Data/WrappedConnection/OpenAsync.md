# WrappedConnection.OpenAsync method

Opens a database connection asynchronously with the settings specified by the ConnectionString property of the provider-specific Connection object.

```csharp
public override Task OpenAsync(CancellationToken cancellationToken)
```

| parameter | description |
| --- | --- |
| cancellationToken | The cancellation token. |

## Return Value

A task that represents the asynchronous operation.

## See Also

* class [WrappedConnection](../WrappedConnection.md)