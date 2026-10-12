# RowJsonConverter class
**namespace:** *[Serenity.JsonConverters](../README.md#serenity.jsonconverters-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Serialize/deserialize a row

```csharp
public class RowJsonConverter : JsonConverter<IRow>
```

## Public Members

| name | description |
| --- | --- |
| [RowJsonConverter](RowJsonConverter/RowJsonConverter.md)() | The default constructor. |
| override [CanConvert](RowJsonConverter/CanConvert.md)(…) |  |
| override [Read](RowJsonConverter/Read.md)(…) |  |
| override [Write](RowJsonConverter/Write.md)(…) |  |
| static [ShouldDeserializeExtension](RowJsonConverter/ShouldDeserializeExtension.md) { get; set; } | Should deserialize extension. Returns the local hook if any is set through [`SetLocalShouldDeserializeExtension`](./RowJsonConverter/SetLocalShouldDeserializeExtension.md), otherwise the default hook. The local hook should be used for unit tests. |
| static [ShouldSerializeExtension](RowJsonConverter/ShouldSerializeExtension.md) { get; set; } | Should serialize extension. Returns the local hook if any is set through [`SetLocalShouldSerializeExtension`](./RowJsonConverter/SetLocalShouldSerializeExtension.md), otherwise the default hook. The local hook should be used for unit tests. |
| static [SetLocalShouldDeserializeExtension](RowJsonConverter/SetLocalShouldDeserializeExtension.md)(…) | Sets the local [`ShouldDeserializeExtension`](./RowJsonConverter/ShouldDeserializeExtension.md) hook for the current thread and async context. Useful for background tasks, async methods, and testing to set the hook locally without affecting other threads or tests. |
| static [SetLocalShouldSerializeExtension](RowJsonConverter/SetLocalShouldSerializeExtension.md)(…) | Sets the local [`ShouldSerializeExtension`](./RowJsonConverter/ShouldSerializeExtension.md) hook for the current thread and async context. Useful for background tasks, async methods, and testing to set the hook locally without affecting other threads or tests. |

## See Also

* interface [IRow](../Serenity.Data/IRow.md)
* **Source:** *[RowJsonConverter.cs](https://github.com/serenity-is/Serenity/blob/a41029d5f581006b844705e0b0f9995c0153d9b9/src/services/Entity/Row/RowJsonConverter.cs)*