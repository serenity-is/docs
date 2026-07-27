# DataServiceCollectionExtensions class
**namespace:** *[Serenity.Extensions.DependencyInjection](../README.md#serenity.extensions.dependencyinjection-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Contains extensions to register data services

```csharp
public static class DataServiceCollectionExtensions
```

## Public Members

| name | description |
| --- | --- |
| static [AddSqlConnections](DataServiceCollectionExtensions/AddSqlConnections.md)(…) | Adds default IConnectionStrings and ISqlConnections interfaces (2 methods) |
| static [GetDataConnectionString](DataServiceCollectionExtensions/GetDataConnectionString.md)(…) | Gets the specified connection string entry from the specified configuration's Data:[name] section. Only for use in Startup where IConnectionStrings is not yet available. Throws if no such connection is found. |

## See Also

* **Source:** *[DataServiceCollectionExtensions.cs](https://github.com/serenity-is/Serenity/blob/master/src/Services/Data/Connections/DataServiceCollectionExtensions.cs)*