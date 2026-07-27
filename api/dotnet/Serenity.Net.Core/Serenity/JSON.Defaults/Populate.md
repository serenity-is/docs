# JSON.Defaults.Populate method
**namespace:** *[Serenity](../../README.md#serenity-namespace)*   **assembly**: *[Serenity.Net.Core](../../README.md)*

Creates a JsonSerializerSettings object with common values and converters.

```csharp
public static JsonSerializerOptions Populate(JsonSerializerOptions options, bool tolerant = false, 
    bool writeNulls = false)
```

| parameter | description |
| --- | --- |
| options | Options to populate with defaults |
| tolerant | True to ignore deserializing unmapped members |
| writeNulls | True to write null values |

## See Also

* class [Defaults](../JSON.Defaults.md)