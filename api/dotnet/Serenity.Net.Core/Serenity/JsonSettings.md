# JsonSettings class
**namespace:** *[Serenity](../README.md#serenity-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Contains default Serenity JSON serialization settings.

```csharp
public static class JsonSettings
```

## Public Members

| name | description |
| --- | --- |
| static [Strict](JsonSettings/Strict.md) | The stricter settings, raises error on missing members / reference loops, ignores nulls. |
| static [StrictIncludeNulls](JsonSettings/StrictIncludeNulls.md) | The stricter settings, raises error on missing members / reference loops, includes nulls. |
| static [Tolerant](JsonSettings/Tolerant.md) | The tolerant settings, ignores missing members, reference loops on deserialization, ignores nulls |
| static [TolerantIncludeNulls](JsonSettings/TolerantIncludeNulls.md) | The tolerant settings, ignores missing members, reference loops on deserialization, includes nulls |
| static [CreateDefaults](JsonSettings/CreateDefaults.md)() | Creates a JsonSerializerSettings object with common values and converters. |

## See Also

* **Source:** *[JsonSettings.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Core/Json/JsonSettings.cs)*