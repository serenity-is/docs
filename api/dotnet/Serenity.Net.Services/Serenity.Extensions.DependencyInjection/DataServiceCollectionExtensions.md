# DataServiceCollectionExtensions class
**namespace:** *[Serenity.Extensions.DependencyInjection](../README.md#serenity.extensions.dependencyinjection-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Contains extensions to register data services.

```csharp
public static class DataServiceCollectionExtensions
```

## Public Members

| name | description |
| --- | --- |
| static [AddSqlConnections](DataServiceCollectionExtensions/AddSqlConnections.md)(…) | Adds the default [`IConnectionStrings`](../Serenity.Data/IConnectionStrings.md) and [`ISqlConnections`](../Serenity.Data/ISqlConnections.md) interfaces. (2 methods) |
| static [GetDataConnectionString](DataServiceCollectionExtensions/GetDataConnectionString.md)(…) | Gets the specified connection string entry from the specified configuration's Data:[name] section. Only for use in Startup where [`IConnectionStrings`](../Serenity.Data/IConnectionStrings.md) is not yet available. Throws if no such connection is found. |

## See Also

* **Source:** *[DataServiceCollectionExtensions.cs](https://github.com/serenity-is/Serenity/blob/a5013fdf777dbbd87589205ddffcb67f18bea673/src/services/Data/Connections/DataServiceCollectionExtensions.cs)*