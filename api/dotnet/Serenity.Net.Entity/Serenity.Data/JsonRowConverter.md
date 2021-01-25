# JsonRowConverter class
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Entity](../README.md)*

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
| static [ShouldSerializeExtension](JsonRowConverter/ShouldSerializeExtension.md) | The should serialize extension |

## See Also

* **Source:** *[JsonRowConverter.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Entity/Row/JsonRowConverter.cs)*