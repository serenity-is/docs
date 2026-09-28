# InterceptExecuteReaderArgs record
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Arguments for intercepting a SQL reader operation.

```csharp
public record InterceptExecuteReaderArgs : IEquatable<InterceptOperationArgs>, 
    IEquatable<InterceptSqlOperationArgs>
```

## Public Members

| name | description |
| --- | --- |
| [InterceptExecuteReaderArgs](InterceptExecuteReaderArgs/InterceptExecuteReaderArgs.md)(…) | Arguments for intercepting a SQL reader operation. |
| [Query](InterceptExecuteReaderArgs/Query.md) { get; set; } |  |

## See Also

* record [InterceptOperationArgs](./InterceptOperationArgs.md)
* record [InterceptSqlOperationArgs](./InterceptSqlOperationArgs.md)
* **Source:** *[InterceptExecuteReaderArgs.cs](https://github.com/serenity-is/Serenity/blob/1547fabf1541054fe943b6a29c0d181fd84080e0/src/services/Data/Interceptors/InterceptExecuteReaderArgs.cs)*