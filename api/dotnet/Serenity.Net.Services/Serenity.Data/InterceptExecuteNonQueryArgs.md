# InterceptExecuteNonQueryArgs record
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Arguments for intercepting a non-query SQL operation.

```csharp
public record InterceptExecuteNonQueryArgs : IEquatable<InterceptOperationArgs>, 
    IEquatable<InterceptSqlOperationArgs>
```

## Public Members

| name | description |
| --- | --- |
| [InterceptExecuteNonQueryArgs](InterceptExecuteNonQueryArgs/InterceptExecuteNonQueryArgs.md)(…) | Arguments for intercepting a non-query SQL operation. |
| [ExpectedRows](InterceptExecuteNonQueryArgs/ExpectedRows.md) { get; set; } |  |
| [GetNewId](InterceptExecuteNonQueryArgs/GetNewId.md) { get; set; } |  |
| [Query](InterceptExecuteNonQueryArgs/Query.md) { get; set; } |  |

## See Also

* record [InterceptOperationArgs](./InterceptOperationArgs.md)
* record [InterceptSqlOperationArgs](./InterceptSqlOperationArgs.md)
* **Source:** *[InterceptExecuteNonQueryArgs.cs](https://github.com/serenity-is/Serenity/blob/1547fabf1541054fe943b6a29c0d181fd84080e0/src/services/Data/Interceptors/InterceptExecuteNonQueryArgs.cs)*