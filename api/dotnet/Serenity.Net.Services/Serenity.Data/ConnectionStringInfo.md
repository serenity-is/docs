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
| [ConnectionKey](ConnectionStringInfo/ConnectionKey.md) { get; } | Gets the connection key. |
| [ConnectionString](ConnectionStringInfo/ConnectionString.md) { get; } | Gets the connection string. |
| [Dialect](ConnectionStringInfo/Dialect.md) { get; } | Gets the dialect. |
| [ProviderName](ConnectionStringInfo/ProviderName.md) { get; } | Gets the name of the provider. |

## Remarks

Initializes a new instance of the [`ConnectionStringInfo`](./ConnectionStringInfo.md) class.

## See Also

* interface [IConnectionString](./IConnectionString.md)
* **Source:** *[ConnectionStringInfo.cs](https://github.com/serenity-is/Serenity/blob/a5013fdf777dbbd87589205ddffcb67f18bea673/src/services/Data/Connections/ConnectionStringInfo.cs)*