# DataServiceCollectionExtensions.AddSqlConnections method (1 of 2)
**namespace:** *[Serenity.Extensions.DependencyInjection](../../README.md#serenity.extensions.dependencyinjection-namespace)*   **assembly**: *[Serenity.Net.Data](../../README.md)*

Adds default IConnectionStrings and ISqlConnections interfaces

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
**namespace:** *[Serenity.Extensions.DependencyInjection](../../README.md#serenity.extensions.dependencyinjection-namespace)*   **assembly**: *[Serenity.Net.Data](../../README.md)*

Adds default IConnectionStrings and ISqlConnections interfaces

```csharp
public static void AddSqlConnections(this IServiceCollection services, 
    Action<ConnectionStringOptions> setupAction)
```

| parameter | description |
| --- | --- |
| services | The service collection. |
| setupAction | Setup action to manually modify connection strings |

## See Also

* class [ConnectionStringOptions](../../Serenity.Data/ConnectionStringOptions.md)
* class [DataServiceCollectionExtensions](../DataServiceCollectionExtensions.md)