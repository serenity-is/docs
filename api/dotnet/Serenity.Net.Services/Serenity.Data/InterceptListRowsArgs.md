# InterceptListRowsArgs record
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Arguments for intercepting an entity list or count operation.

```csharp
public record InterceptListRowsArgs : IEquatable<InterceptOperationArgs>
```

## Public Members

| name | description |
| --- | --- |
| [InterceptListRowsArgs](InterceptListRowsArgs/InterceptListRowsArgs.md)(…) | Arguments for intercepting an entity list or count operation. |
| [CountOnly](InterceptListRowsArgs/CountOnly.md) { get; set; } |  |
| [Query](InterceptListRowsArgs/Query.md) { get; set; } |  |
| [Type](InterceptListRowsArgs/Type.md) { get; set; } |  |

## See Also

* record [InterceptOperationArgs](./InterceptOperationArgs.md)
* **Source:** *[InterceptListRowsArgs.cs](https://github.com/serenity-is/Serenity/blob/1547fabf1541054fe943b6a29c0d181fd84080e0/src/services/Entity/Interceptors/InterceptListRowsArgs.cs)*