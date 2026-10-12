# AliasExtensions class
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Contains extension methods for Alias objects.

```csharp
public static class AliasExtensions
```

## Public Members

| name | description |
| --- | --- |
| static [WithNoLock](AliasExtensions/WithNoLock.md)(…) | Adds a WITH(NOLOCK) to the alias and returns a new alias. The alias name itself stays clean, so column references are unaffected; only FROM / JOIN rendering includes the hint. |
| static [WithTableHint](AliasExtensions/WithTableHint.md)(…) | Adds a WITH(...) table hint to the alias and returns a new alias. The alias name itself stays clean, so column references are unaffected; only FROM / JOIN rendering includes the hint. |

## See Also

* **Source:** *[AliasExtensions.cs](https://github.com/serenity-is/Serenity/blob/c53b8611c9842f9b209d94885438e10f9ede98f1/src/services/Data/Join/AliasExtensions.cs)*