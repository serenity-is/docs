# InterceptSqlOperationArgs record
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Base arguments shared by SQL interceptor operations.

```csharp
public abstract record InterceptSqlOperationArgs : IEquatable<InterceptOperationArgs>
```

## Public Members

| name | description |
| --- | --- |
| [CommandText](InterceptSqlOperationArgs/CommandText.md) { get; set; } |  |
| [Parameters](InterceptSqlOperationArgs/Parameters.md) { get; set; } |  |

## Protected Members

| name | description |
| --- | --- |
| [InterceptSqlOperationArgs](InterceptSqlOperationArgs/InterceptSqlOperationArgs.md)(…) | Base arguments shared by SQL interceptor operations. |

## See Also

* record [InterceptOperationArgs](./InterceptOperationArgs.md)
* **Source:** *[InterceptSqlOperationArgs.cs](https://github.com/serenity-is/Serenity/blob/1547fabf1541054fe943b6a29c0d181fd84080e0/src/services/Data/Interceptors/InterceptSqlOperationArgs.cs)*