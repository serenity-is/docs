# DataServiceCollectionExtensions.GetDataConnectionString method
**namespace:** *[Serenity.Extensions.DependencyInjection](../../README.md#serenity.extensions.dependencyinjection-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Gets the specified connection string entry from the specified configuration's Data:[name] section. Only for use in Startup where IConnectionStrings is not yet available. Throws if no such connection is found.

```csharp
public static ConnectionStringEntry GetDataConnectionString(this IConfiguration configuration, 
    string name)
```

| parameter | description |
| --- | --- |
| configuration | The configuration to enumerate. |
| name | The connection string key. |

## Return Value

The connection string entry from Data:[name].

## See Also

* class [ConnectionStringEntry](../../Serenity.Data/ConnectionStringEntry.md)
* class [DataServiceCollectionExtensions](../DataServiceCollectionExtensions.md)