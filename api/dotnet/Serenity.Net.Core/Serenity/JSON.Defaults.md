# JSON.Defaults class
**namespace:** *[Serenity](../README.md#serenity-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Contains default options for System.Text.Json serialization

```csharp
public static class Defaults
```

## Public Members

| name | description |
| --- | --- |
| static readonly [Strict](JSON.Defaults/Strict.md) | The stricter settings, raises error on missing members / reference loops, skips nulls when serializing |
| static readonly [StrictWriteNulls](JSON.Defaults/StrictWriteNulls.md) | The stricter settings, raises error on missing members / reference loops, writes nulls |
| static readonly [Tolerant](JSON.Defaults/Tolerant.md) | The tolerant settings, ignores missing members, reference loops on deserialization, skips nulls when serializing |
| static readonly [TolerantWriteNulls](JSON.Defaults/TolerantWriteNulls.md) | The tolerant settings, ignores missing members, reference loops on deserialization, writes nulls |
| static [Populate](JSON.Defaults/Populate.md)(…) | Creates a JsonSerializerSettings object with common values and converters. |

## See Also

* class [JSON](JSON.md)