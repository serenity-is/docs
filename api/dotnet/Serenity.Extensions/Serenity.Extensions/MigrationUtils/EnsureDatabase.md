# MigrationUtils.EnsureDatabase method
**namespace:** *[Serenity.Extensions](../../README.md#serenity.extensions-namespace)*   **assembly**: *[Serenity.Extensions](../../README.md)*

Ensures the database for the specified connection key exists, creating it if necessary.

```csharp
public static void EnsureDatabase(string databaseKey, string contentRoot, 
    ISqlConnections sqlConnections)
```

| parameter | description |
| --- | --- |
| databaseKey | The connection key. |
| contentRoot | The content root path, used for local databases and Sqlite files. |
| sqlConnections | The SQL connections. |

## See Also

* interface [ISqlConnections](../Serenity.Net.Services/../../Serenity.Data/ISqlConnections.md)
* class [MigrationUtils](../MigrationUtils.md)