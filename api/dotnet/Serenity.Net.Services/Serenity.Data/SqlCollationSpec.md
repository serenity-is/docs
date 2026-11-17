# SqlCollationSpec structure
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

An engine independent description of the comparison a collation should perform.

```csharp
public struct SqlCollationSpec : IEquatable<SqlCollationSpec>
```

| parameter | description |
| --- | --- |
| Culture | The culture name, an empty string for the invariant culture, or null for an ordinal comparison. |
| IgnoreCase | True to compare case insensitively. |
| IgnoreAccents | True to compare accent insensitively. |

## Public Members

| name | description |
| --- | --- |
| [SqlCollationSpec](SqlCollationSpec/SqlCollationSpec.md)(…) | An engine independent description of the comparison a collation should perform. |
| [Culture](SqlCollationSpec/Culture.md) { get; set; } | The culture name, an empty string for the invariant culture, or null for an ordinal comparison. |
| [IgnoreAccents](SqlCollationSpec/IgnoreAccents.md) { get; set; } | True to compare accent insensitively. |
| [IgnoreCase](SqlCollationSpec/IgnoreCase.md) { get; set; } | True to compare case insensitively. |
| override [ToString](SqlCollationSpec/ToString.md)() |  |
| static [TryParse](SqlCollationSpec/TryParse.md)(…) | Tries to parse a comparer specification as accepted by [`ComparerResolver`](./ComparerResolver.md), e.g. "Ordinal", "OrdinalIgnoreCase", "InvariantCulture" or "tr-TR:IgnoreCase:IgnoreAccents". |

## See Also

* **Source:** *[SqlCollationSpec.cs](https://github.com/serenity-is/Serenity/blob/64f4d46040be54ec435d5a0cabde26e1c69fe085/src/services/Data/Collations/SqlCollationSpec.cs)*