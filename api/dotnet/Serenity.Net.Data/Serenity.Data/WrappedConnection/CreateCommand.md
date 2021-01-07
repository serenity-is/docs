# WrappedConnection.CreateCommand method
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Data](../../README.md)*

Creates and returns a Command object associated with the connection.

```csharp
public IDbCommand CreateCommand()
```

## Return Value

A Command object associated with the connection.

## Exceptions

| exception | condition |
| --- | --- |
| Exception | Active transaction for connection is in invalid state! " + "Connection was probably closed unexpectedly! or Can't set transaction for command! " + "Connection was probably closed unexpectedly! |

## See Also

* class [WrappedConnection](../WrappedConnection.md)