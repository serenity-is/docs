# RegexWithDefault class
**namespace:** *[Serenity.Extensions](../README.md#serenity.extensions-namespace)*   **assembly**: *[Serenity.Extensions](../README.md)*

Combines a regular expression that adds to a default one, so that configuring a pattern can't lose what the default covers by accident, like sensitive tables. Leaving out the default takes setting an option for that.

```csharp
public static class RegexWithDefault
```

## Public Members

| name | description |
| --- | --- |
| static [Combine](RegexWithDefault/Combine.md)(…) | Gets the regular expression matching what the default or the configured pattern matches. |

## See Also

* **Source:** *[RegexWithDefault.cs](https://github.com/serenity-is/Serenity/blob/0c4087286691f6a7cd552356b999272391bcf9de/common-features/src/extensions/Modules/Options/RegexWithDefault.cs)*