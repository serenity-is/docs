# IConnectionString interface
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Contains a connection string, its key and provider name.

```csharp
public interface IConnectionString
```

## Members

| name | description |
| --- | --- |
| [Collation](IConnectionString/Collation.md) { get; } | Gets the default collation to use if the database for this connection is created by the application, or null to use the default of the server. |
| [Comparer](IConnectionString/Comparer.md) { get; } | Gets the comparer specification of this connection, if any. |
| [ConnectionKey](IConnectionString/ConnectionKey.md) { get; } | Gets the connection key. |
| [ConnectionString](IConnectionString/ConnectionString.md) { get; } | Gets the connection string. |
| [Dialect](IConnectionString/Dialect.md) { get; } | Gets the dialect. |
| [PartialContainment](IConnectionString/PartialContainment.md) { get; } | Gets a value indicating whether a SQL Server database for this connection is created as a partially contained database, if it is created by the application. |
| [ProviderName](IConnectionString/ProviderName.md) { get; } | Gets the name of the provider. |

## See Also

* **Source:** *[IConnectionString.cs](https://github.com/serenity-is/Serenity/blob/64f4d46040be54ec435d5a0cabde26e1c69fe085/src/services/Data/Connections/IConnectionString.cs)*