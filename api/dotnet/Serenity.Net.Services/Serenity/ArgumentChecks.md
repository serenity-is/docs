# ArgumentChecks class
**namespace:** *[Serenity](../README.md#serenity-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Argument check helpers for validating that non-null values obtained from members (e.g. `request.Entity`) are not null, returning the value when it is not. Prefer ArgumentNullException static `ThrowIfNull` when checking an actual method parameter, as that keeps the parameter name recognized by CA2208 and null-state flow analysis.

```csharp
public static class ArgumentChecks
```

## Public Members

| name | description |
| --- | --- |
| static [NotNull&lt;T&gt;](ArgumentChecks/NotNull.md)(…) | Throws an ArgumentNullException if *argument* is null, otherwise returns it. (2 methods) |

## See Also

* **Source:** *[ArgumentChecks.cs](https://github.com/serenity-is/Serenity/blob/863efadd219f60621f4ec24faf3728a6a7a4290c/src/services/Common/ArgumentChecks.cs)*