# MigrationUtils.ClearAllPools method

Clears the connection pools of the database provider for the specified connection key, so that connections opened before the database was created are not reused. Does nothing if the provider is not registered, or its connection type has no static ClearAllPools method.

```csharp
public static void ClearAllPools(string databaseKey, ISqlConnections sqlConnections)
```

| parameter | description |
| --- | --- |
| databaseKey | The connection key. |
| sqlConnections | The SQL connections. |

## See Also

* interface [ISqlConnections](../../../Serenity.Net.Services/Serenity.Data/ISqlConnections.md)
* class [MigrationUtils](../MigrationUtils.md)