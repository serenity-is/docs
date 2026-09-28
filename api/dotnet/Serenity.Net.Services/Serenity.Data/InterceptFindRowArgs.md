# InterceptFindRowArgs record
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Arguments for intercepting an entity find operation.

```csharp
public record InterceptFindRowArgs : IEquatable<InterceptOperationArgs>
```

## Public Members

| name | description |
| --- | --- |
| [InterceptFindRowArgs](InterceptFindRowArgs/InterceptFindRowArgs.md)(…) | Arguments for intercepting an entity find operation. |
| [ByIdOrSingle](InterceptFindRowArgs/ByIdOrSingle.md) { get; set; } |  |
| [Id](InterceptFindRowArgs/Id.md) { get; set; } |  |
| [Query](InterceptFindRowArgs/Query.md) { get; set; } |  |
| [Type](InterceptFindRowArgs/Type.md) { get; set; } |  |

## See Also

* record [InterceptOperationArgs](./InterceptOperationArgs.md)
* **Source:** *[InterceptFindRowArgs.cs](https://github.com/serenity-is/Serenity/blob/1547fabf1541054fe943b6a29c0d181fd84080e0/src/services/Entity/Interceptors/InterceptFindRowArgs.cs)*