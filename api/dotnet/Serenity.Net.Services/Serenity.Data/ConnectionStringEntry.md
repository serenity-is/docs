# ConnectionStringEntry class
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

A connection string setting.

```csharp
public class ConnectionStringEntry
```

## Public Members

| name | description |
| --- | --- |
| [ConnectionStringEntry](ConnectionStringEntry/ConnectionStringEntry.md)() | The default constructor. |
| [ConnectionString](ConnectionStringEntry/ConnectionString.md) { get; set; } | Gets or sets the connection string. |
| [Dialect](ConnectionStringEntry/Dialect.md) { get; set; } | Gets or sets the dialect name. |
| [DialectInstance](ConnectionStringEntry/DialectInstance.md) { get; set; } | Gets or sets the dialect instance. |
| [FallbackFor](ConnectionStringEntry/FallbackFor.md) { get; set; } | Gets or sets a semicolon-separated list of connection keys that fall back to this connection when they are not configured. For example, "ProFeatures;ProWorkLog". |
| [FallbackForKeys](ConnectionStringEntry/FallbackForKeys.md) { get; } | Gets the parsed, trimmed connection keys from [`FallbackFor`](ConnectionStringEntry/FallbackFor.md), split on ';'. Returns an empty set when [`FallbackFor`](ConnectionStringEntry/FallbackFor.md) is null or empty. Parsed lazily and cached. |
| [ProviderName](ConnectionStringEntry/ProviderName.md) { get; set; } | Gets or sets the provider name. |

## See Also

* **Source:** *[ConnectionStringEntry.cs](https://github.com/serenity-is/Serenity/blob/fa8ddd78cf707d00a1aca68d898e31e73d5971b9/src/services/Data/Connections/ConnectionStringEntry.cs)*