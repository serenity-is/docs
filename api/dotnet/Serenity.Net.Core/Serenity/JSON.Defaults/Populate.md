# JSON.Defaults.Populate method

Creates a JsonSerializerOptions object with the common Serenity values and converters.

```csharp
public static JsonSerializerOptions Populate(JsonSerializerOptions options, bool tolerant = false, 
    bool writeNulls = false)
```

| parameter | description |
| --- | --- |
| options | The options to populate with defaults. |
| tolerant | `true` to ignore unmapped members when deserializing. |
| writeNulls | `true` to write null values. |

## Return Value

The populated JsonSerializerOptions instance.

## See Also

* class [Defaults](../JSON.Defaults.md)