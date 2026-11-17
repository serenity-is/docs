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
| [Collation](ConnectionStringEntry/Collation.md) { get; set; } | Gets or sets the default collation to use if the database for this connection is created by the application, in the format of the database engine, e.g. "Turkish_100_CI_AS" for SQL Server. It has no effect on a database that already exists. Defaults to null, meaning the database is created with the default collation of the server. |
| [Comparer](ConnectionStringEntry/Comparer.md) { get; set; } | Gets or sets the comparer specification used to compare string field values for this connection, e.g. "Ordinal", "OrdinalIgnoreCase", "CurrentCultureIgnoreCase", "tr-TR" or "tr-TR:IgnoreCase". Defaults to null, meaning [`DefaultComparer`](./SqlSettings/DefaultComparer.md) is used. |
| [ConnectionString](ConnectionStringEntry/ConnectionString.md) { get; set; } | Gets or sets the connection string. |
| [Dialect](ConnectionStringEntry/Dialect.md) { get; set; } | Gets or sets the dialect name. |
| [DialectInstance](ConnectionStringEntry/DialectInstance.md) { get; set; } | Gets or sets the dialect instance. |
| [FallbackFor](ConnectionStringEntry/FallbackFor.md) { get; set; } | Gets or sets a semicolon-separated list of connection keys that fall back to this connection when they are not configured. For example, "ProFeatures;ProWorkLog". |
| [FallbackForKeys](ConnectionStringEntry/FallbackForKeys.md) { get; } | Gets the parsed, trimmed connection keys from [`FallbackFor`](./ConnectionStringEntry/FallbackFor.md), split on ';'. Returns an empty set when [`FallbackFor`](./ConnectionStringEntry/FallbackFor.md) is null or empty. Parsed lazily and cached. |
| [PartialContainment](ConnectionStringEntry/PartialContainment.md) { get; set; } | Gets or sets a value indicating whether a SQL Server database for this connection is created as a partially contained database, if it is created by the application. Table and column names of such a database are compared by a fixed case insensitive collation, whatever [`Collation`](./ConnectionStringEntry/Collation.md) is. |
| [ProviderName](ConnectionStringEntry/ProviderName.md) { get; set; } | Gets or sets the provider name. |

## See Also

* **Source:** *[ConnectionStringEntry.cs](https://github.com/serenity-is/Serenity/blob/64f4d46040be54ec435d5a0cabde26e1c69fe085/src/services/Data/Connections/ConnectionStringEntry.cs)*