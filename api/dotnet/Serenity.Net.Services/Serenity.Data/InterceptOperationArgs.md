# InterceptOperationArgs record
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Base arguments shared by intercepted operations.

```csharp
public abstract record InterceptOperationArgs
```

## Public Members

| name | description |
| --- | --- |
| [CancellationToken](InterceptOperationArgs/CancellationToken.md) { get; set; } | Gets or initializes the cancellation token for asynchronous execution. |
| [IsAsync](InterceptOperationArgs/IsAsync.md) { get; set; } | Gets or initializes whether the operation was invoked asynchronously. |

## Protected Members

| name | description |
| --- | --- |
| [InterceptOperationArgs](InterceptOperationArgs/InterceptOperationArgs.md)() | The default constructor. |

## See Also

* **Source:** *[InterceptOperationArgs.cs](https://github.com/serenity-is/Serenity/blob/1547fabf1541054fe943b6a29c0d181fd84080e0/src/services/Data/Interceptors/InterceptOperationArgs.cs)*