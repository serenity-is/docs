# DataServiceCollectionExtensions.AddSqlConnections method (1 of 2)

Adds the default [`IConnectionStrings`](../../Serenity.Data/IConnectionStrings.md) and [`ISqlConnections`](../../Serenity.Data/ISqlConnections.md) interfaces.

```csharp
public static void AddSqlConnections(this IServiceCollection services)
```

| parameter | description |
| --- | --- |
| services | The service collection. |

## See Also

* class [DataServiceCollectionExtensions](../DataServiceCollectionExtensions.md)

---

# DataServiceCollectionExtensions.AddSqlConnections method (2 of 2)

Adds the default [`IConnectionStrings`](../../Serenity.Data/IConnectionStrings.md) and [`ISqlConnections`](../../Serenity.Data/ISqlConnections.md) interfaces.

```csharp
public static void AddSqlConnections(this IServiceCollection services, 
    Action<ConnectionStringOptions> setupAction)
```

| parameter | description |
| --- | --- |
| services | The service collection. |
| setupAction | The setup action to manually modify connection strings. |

## See Also

* class [ConnectionStringOptions](../../Serenity.Data/ConnectionStringOptions.md)
* class [DataServiceCollectionExtensions](../DataServiceCollectionExtensions.md)