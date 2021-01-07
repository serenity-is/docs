# JsonCriteriaConverter class
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Data](../README.md)*

Serialize/deserialize a BaseCriteria object

```csharp
public class JsonCriteriaConverter : JsonConverter
```

## Public Members

| name | description |
| --- | --- |
| [JsonCriteriaConverter](JsonCriteriaConverter/JsonCriteriaConverter.md)() | The default constructor. |
| override [CanRead](JsonCriteriaConverter/CanRead.md) { get; } | Gets a value indicating whether this JsonConverter can read JSON. |
| override [CanWrite](JsonCriteriaConverter/CanWrite.md) { get; } | Gets a value indicating whether this JsonConverter can write JSON. |
| override [CanConvert](JsonCriteriaConverter/CanConvert.md)(…) | Determines whether this instance can convert the specified object type. |
| override [ReadJson](JsonCriteriaConverter/ReadJson.md)(…) | Reads the JSON representation of the object. |
| override [WriteJson](JsonCriteriaConverter/WriteJson.md)(…) | Writes the JSON representation of the object. |

## See Also

* **Source:** *[JsonCriteriaConverter.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Data/Criteria/JsonCriteriaConverter.cs)*