# JsonSortByConverter class
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Serialize/deserialize a SortBy object as string

```csharp
public class JsonSortByConverter : JsonConverter
```

| parameter | description |
| --- | --- |
| T | Type |

## Public Members

| name | description |
| --- | --- |
| [JsonSortByConverter](JsonSortByConverter/JsonSortByConverter.md)() | The default constructor. |
| override [CanRead](JsonSortByConverter/CanRead.md) { get; } | Gets a value indicating whether this JsonConverter can read JSON. |
| override [CanWrite](JsonSortByConverter/CanWrite.md) { get; } | Gets a value indicating whether this JsonConverter can write JSON. |
| override [CanConvert](JsonSortByConverter/CanConvert.md)(…) | Determines whether this instance can convert the specified object type. |
| override [ReadJson](JsonSortByConverter/ReadJson.md)(…) | Reads the JSON representation of the object. |
| override [WriteJson](JsonSortByConverter/WriteJson.md)(…) | Writes the JSON representation of the object. |

## See Also

* **Source:** *[JsonSortByConverter.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Services/Json/JsonSortByConverter.cs)*