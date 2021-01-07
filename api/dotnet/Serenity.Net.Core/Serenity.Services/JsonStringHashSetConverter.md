# JsonStringHashSetConverter class
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Serialize/deserialize a IdentifierSet object as string

```csharp
public class JsonStringHashSetConverter : JsonConverter
```

## Public Members

| name | description |
| --- | --- |
| [JsonStringHashSetConverter](JsonStringHashSetConverter/JsonStringHashSetConverter.md)() | The default constructor. |
| override [CanRead](JsonStringHashSetConverter/CanRead.md) { get; } | Gets a value indicating whether this JsonConverter can read JSON. |
| override [CanWrite](JsonStringHashSetConverter/CanWrite.md) { get; } | Gets a value indicating whether this JsonConverter can write JSON. |
| override [CanConvert](JsonStringHashSetConverter/CanConvert.md)(…) | Determines whether this instance can convert the specified object type. |
| override [ReadJson](JsonStringHashSetConverter/ReadJson.md)(…) | Reads the JSON representation of the object. |
| override [WriteJson](JsonStringHashSetConverter/WriteJson.md)(…) | Writes the JSON representation of the object. |

## See Also

* **Source:** *[JsonStringHashSetConverter.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Core/Json/JsonStringHashSetConverter.cs)*