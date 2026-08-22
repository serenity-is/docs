# JsonSettings class
**namespace:** *[Serenity](../README.md#serenity-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Contains the default Serenity JSON serialization settings for Newtonsoft.Json.

```csharp
public static class JsonSettings
```

## Public Members

| name | description |
| --- | --- |
| static [Strict](JsonSettings/Strict.md) | The stricter settings, which raise an error on missing members and reference loops, and ignore nulls. |
| static [StrictIncludeNulls](JsonSettings/StrictIncludeNulls.md) | The stricter settings, which raise an error on missing members and reference loops, and include nulls. |
| static [Tolerant](JsonSettings/Tolerant.md) | The tolerant settings, which ignore missing members and reference loops on deserialization, and ignore nulls. |
| static [TolerantIncludeNulls](JsonSettings/TolerantIncludeNulls.md) | The tolerant settings, which ignore missing members and reference loops on deserialization, and include nulls. |
| static [CreateDefaults](JsonSettings/CreateDefaults.md)() | Creates a JsonSerializerSettings object with the common Serenity values and converters. |

## See Also

* **Source:** *[JsonSettings.cs](https://github.com/serenity-is/Serenity/blob/a5013fdf777dbbd87589205ddffcb67f18bea673/src/core/Json/JsonSettings.cs)*