# JsonStringHashSetConverter class
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Serializes and deserializes a HashSet of strings as a JSON array.

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

* **Source:** *[JsonStringHashSetConverter.cs](https://github.com/serenity-is/Serenity/blob/a5013fdf777dbbd87589205ddffcb67f18bea673/src/core/Json/JsonStringHashSetConverter.cs)*