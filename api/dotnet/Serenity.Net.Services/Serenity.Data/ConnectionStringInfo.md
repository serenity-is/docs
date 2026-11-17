# ConnectionStringInfo class
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Contains a connection string, its key, and provider name.

```csharp
public class ConnectionStringInfo : IConnectionString
```

| parameter | description |
| --- | --- |
| connectionKey | The connection key. |
| connectionString | The connection string. |
| providerName | The name of the provider. |
| dialect | The SQL dialect. |

## Public Members

| name | description |
| --- | --- |
| [ConnectionStringInfo](ConnectionStringInfo/ConnectionStringInfo.md)(…) | Contains a connection string, its key, and provider name. |
| [Collation](ConnectionStringInfo/Collation.md) { get; set; } | Gets the default collation to use if the database for this connection is created by the application, or null to use the default of the server. |
| [Comparer](ConnectionStringInfo/Comparer.md) { get; set; } | Gets the comparer specification of this connection, if any. |
| [ConnectionKey](ConnectionStringInfo/ConnectionKey.md) { get; } | Gets the connection key. |
| [ConnectionString](ConnectionStringInfo/ConnectionString.md) { get; } | Gets the connection string. |
| [Dialect](ConnectionStringInfo/Dialect.md) { get; } | Gets the dialect. |
| [PartialContainment](ConnectionStringInfo/PartialContainment.md) { get; set; } | Gets a value indicating whether a SQL Server database for this connection is created as a partially contained database, if it is created by the application. |
| [ProviderName](ConnectionStringInfo/ProviderName.md) { get; } | Gets the name of the provider. |

## Remarks

Initializes a new instance of the [`ConnectionStringInfo`](./ConnectionStringInfo.md) class.

## See Also

* interface [IConnectionString](./IConnectionString.md)
* **Source:** *[ConnectionStringInfo.cs](https://github.com/serenity-is/Serenity/blob/64f4d46040be54ec435d5a0cabde26e1c69fe085/src/services/Data/Connections/ConnectionStringInfo.cs)*