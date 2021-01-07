# JSON class
**namespace:** *[Serenity](../README.md#serenity-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Contains shortcuts to Newtonsoft.Json serialization / deserialization methods, and default Serenity settings.

```csharp
public static class JSON
```

## Public Members

| name | description |
| --- | --- |
| static [Parse](JSON/Parse.md)(…) | Deserializes a JSON string to an object |
| static [Parse&lt;T&gt;](JSON/Parse.md)(…) | Deserializes a JSON string to an object |
| static [ParseTolerant](JSON/ParseTolerant.md)(…) | Deserializes a JSON string to an object, using more tolerant settings |
| static [ParseTolerant&lt;T&gt;](JSON/ParseTolerant.md)(…) | Deserializes a JSON string to an object, using more tolerant settings. |
| static [Stringify](JSON/Stringify.md)(…) | Converts object to its JSON representation |
| static [StringifyIndented](JSON/StringifyIndented.md)(…) | Converts object to its JSON representation |
| static [ToJson](JSON/ToJson.md)(…) | Converts an object to its JSON representation (extension method for Stringify) |

## See Also

* **Source:** *[Json.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Core/Json/Json.cs)*