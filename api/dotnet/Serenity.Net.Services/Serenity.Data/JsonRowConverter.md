# JsonRowConverter class
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Serialize/deserialize a row

```csharp
public class JsonRowConverter : JsonConverter
```

## Public Members

| name | description |
| --- | --- |
| [JsonRowConverter](JsonRowConverter/JsonRowConverter.md)() | The default constructor. |
| override [CanRead](JsonRowConverter/CanRead.md) { get; } | Gets a value indicating whether this JsonConverter can read JSON. |
| override [CanWrite](JsonRowConverter/CanWrite.md) { get; } | Gets a value indicating whether this JsonConverter can write JSON. |
| override [CanConvert](JsonRowConverter/CanConvert.md)(…) | Determines whether this instance can convert the specified object type. |
| override [ReadJson](JsonRowConverter/ReadJson.md)(…) | Reads the JSON representation of the object. |
| override [WriteJson](JsonRowConverter/WriteJson.md)(…) | Writes the JSON representation of the object. |
| static [ShouldDeserializeExtension](JsonRowConverter/ShouldDeserializeExtension.md) { get; set; } | Should deserialize extension |
| static [ShouldSerializeExtension](JsonRowConverter/ShouldSerializeExtension.md) { get; set; } | Should serialize extension |
| static [SetLocalShouldDeserializeExtension](JsonRowConverter/SetLocalShouldDeserializeExtension.md)(…) | Sets the local [`ShouldDeserializeExtension`](./JsonRowConverter/ShouldDeserializeExtension.md) hook for the current thread and async context. Useful for background tasks, async methods, and testing to set the hook locally without affecting other threads or tests. |
| static [SetLocalShouldSerializeExtension](JsonRowConverter/SetLocalShouldSerializeExtension.md)(…) | Sets the local [`ShouldSerializeExtension`](./JsonRowConverter/ShouldSerializeExtension.md) hook for the current thread and async context. Useful for background tasks, async methods, and testing to set the hook locally without affecting other threads or tests. |

## See Also

* **Source:** *[Newtonsoft.JsonRowConverter.cs](https://github.com/serenity-is/Serenity/blob/2c895c355fe09b3459b5091b6d2e792ced719b68/src/services/Entity/Row/Newtonsoft.JsonRowConverter.cs)*