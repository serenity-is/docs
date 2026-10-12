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
| [Comparer](ConnectionStringEntry/Comparer.md) { get; set; } | Gets or sets the comparer specification used to compare string field values for this connection, e.g. "Ordinal", "OrdinalIgnoreCase", "CurrentCultureIgnoreCase", "tr-TR" or "tr-TR:IgnoreCase". Defaults to null, meaning [`DefaultComparer`](./SqlSettings/DefaultComparer.md) is used. |
| [ConnectionString](ConnectionStringEntry/ConnectionString.md) { get; set; } | Gets or sets the connection string. |
| [Dialect](ConnectionStringEntry/Dialect.md) { get; set; } | Gets or sets the dialect name. |
| [DialectInstance](ConnectionStringEntry/DialectInstance.md) { get; set; } | Gets or sets the dialect instance. |
| [FallbackFor](ConnectionStringEntry/FallbackFor.md) { get; set; } | Gets or sets a semicolon-separated list of connection keys that fall back to this connection when they are not configured. For example, "ProFeatures;ProWorkLog". |
| [FallbackForKeys](ConnectionStringEntry/FallbackForKeys.md) { get; } | Gets the parsed, trimmed connection keys from [`FallbackFor`](./ConnectionStringEntry/FallbackFor.md), split on ';'. Returns an empty set when [`FallbackFor`](./ConnectionStringEntry/FallbackFor.md) is null or empty. Parsed lazily and cached. |
| [ProviderName](ConnectionStringEntry/ProviderName.md) { get; set; } | Gets or sets the provider name. |

## See Also

* **Source:** *[ConnectionStringEntry.cs](https://github.com/serenity-is/Serenity/blob/f828b609b385564332aeeec6f0d6a031cde4142f/src/services/Data/Connections/ConnectionStringEntry.cs)*