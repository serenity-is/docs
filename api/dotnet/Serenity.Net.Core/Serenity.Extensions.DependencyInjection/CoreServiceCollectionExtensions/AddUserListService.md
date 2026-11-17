# CoreServiceCollectionExtensions.AddUserListService&lt;TUserListService&gt; method

Adds the given [`IUserListService`](../../Serenity.Abstractions/IUserListService.md) implementation, which lists the users for the services that need to pick them, e.g. the editors. It is optional, so the ones that use it work without when it is not added.

```csharp
public static IServiceCollection AddUserListService<TUserListService>(
    this IServiceCollection services)
    where TUserListService : class, IUserListService
```

| parameter | description |
| --- | --- |
| TUserListService | The type of the user list service. |
| services | The service collection. |

## See Also

* interface [IUserListService](../../Serenity.Abstractions/IUserListService.md)
* class [CoreServiceCollectionExtensions](../CoreServiceCollectionExtensions.md)