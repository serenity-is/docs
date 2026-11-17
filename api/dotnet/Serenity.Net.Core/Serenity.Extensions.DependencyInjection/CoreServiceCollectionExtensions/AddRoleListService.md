# CoreServiceCollectionExtensions.AddRoleListService&lt;TRoleListService&gt; method

Adds the given [`IRoleListService`](../../Serenity.Abstractions/IRoleListService.md) implementation, which lists the roles for the services that need to pick them, e.g. the editors. It is optional, so the ones that use it work without when it is not added.

```csharp
public static IServiceCollection AddRoleListService<TRoleListService>(
    this IServiceCollection services)
    where TRoleListService : class, IRoleListService
```

| parameter | description |
| --- | --- |
| TRoleListService | The type of the role list service. |
| services | The service collection. |

## See Also

* interface [IRoleListService](../../Serenity.Abstractions/IRoleListService.md)
* class [CoreServiceCollectionExtensions](../CoreServiceCollectionExtensions.md)