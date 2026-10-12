# ComparerResolver class
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Parses comparer specifications like "Ordinal", "OrdinalIgnoreCase", "CurrentCulture", "CurrentCultureIgnoreCase", "tr-TR" or "tr-TR:IgnoreCase" into a StringComparer.

```csharp
public static class ComparerResolver
```

## Public Members

| name | description |
| --- | --- |
| static [Parse](ComparerResolver/Parse.md)(…) | Parses the specified comparer specification. Returns null for null or empty values. |
| static [TryParse](ComparerResolver/TryParse.md)(…) | Tries to parse the specified comparer specification. |

## See Also

* **Source:** *[ComparerResolver.cs](https://github.com/serenity-is/Serenity/blob/f828b609b385564332aeeec6f0d6a031cde4142f/src/services/Data/SqlHelpers/ComparerResolver.cs)*