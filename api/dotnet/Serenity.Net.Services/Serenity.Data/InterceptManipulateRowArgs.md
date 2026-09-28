# InterceptManipulateRowArgs record
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Arguments for intercepting an entity row manipulation operation.

```csharp
public record InterceptManipulateRowArgs : IEquatable<InterceptOperationArgs>
```

## Public Members

| name | description |
| --- | --- |
| [InterceptManipulateRowArgs](InterceptManipulateRowArgs/InterceptManipulateRowArgs.md)(…) | Arguments for intercepting an entity row manipulation operation. |
| [ExpectedRows](InterceptManipulateRowArgs/ExpectedRows.md) { get; set; } |  |
| [GetNewId](InterceptManipulateRowArgs/GetNewId.md) { get; set; } |  |
| [Id](InterceptManipulateRowArgs/Id.md) { get; set; } |  |
| [Row](InterceptManipulateRowArgs/Row.md) { get; set; } |  |
| [Type](InterceptManipulateRowArgs/Type.md) { get; set; } |  |

## See Also

* record [InterceptOperationArgs](./InterceptOperationArgs.md)
* **Source:** *[InterceptManipulateRowArgs.cs](https://github.com/serenity-is/Serenity/blob/1547fabf1541054fe943b6a29c0d181fd84080e0/src/services/Entity/Interceptors/InterceptManipulateRowArgs.cs)*