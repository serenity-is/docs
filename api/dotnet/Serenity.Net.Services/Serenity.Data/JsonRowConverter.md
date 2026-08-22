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

## See Also

* **Source:** *[Newtonsoft.JsonRowConverter.cs](https://github.com/serenity-is/Serenity/blob/a208f637c41c1cd64c6a2dff54e77302d53f73a8/src/services/Entity/Row/Newtonsoft.JsonRowConverter.cs)*