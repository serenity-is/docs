# CoreServiceCollectionExtensions.AddUserProvider method (1 of 3)
**namespace:** *[Serenity.Extensions.DependencyInjection](../../README.md#serenity.extensions.dependencyinjection-namespace)*   **assembly**: *[Serenity.Net.Core](../../README.md)*

Adds the [`DefaultUserProvider`](../../Serenity.Services/DefaultUserProvider.md) as [`IUserProvider`](../../Serenity.Abstractions/IUserProvider.md) implementation to the service collection. Note that it requires IUserRetrieveService, IUserAcessor to be registered in the service collection. It also tries to register the DefaultUserClaimCreator.

```csharp
public static IServiceCollection AddUserProvider(this IServiceCollection services)
```

| parameter | description |
| --- | --- |
| services | The service collection. |

## See Also

* class [CoreServiceCollectionExtensions](../CoreServiceCollectionExtensions.md)

---

# CoreServiceCollectionExtensions.AddUserProvider&lt;TUserAccessor,TUserRetrieveService&gt; method (2 of 3)
**namespace:** *[Serenity.Extensions.DependencyInjection](../../README.md#serenity.extensions.dependencyinjection-namespace)*   **assembly**: *[Serenity.Net.Core](../../README.md)*

Adds the [`DefaultUserProvider`](../../Serenity.Services/DefaultUserProvider.md) as [`IUserProvider`](../../Serenity.Abstractions/IUserProvider.md) implementation to the service collection. Also registers the given IUserAccessor and IUserRetrieveService implementations and tries to register the DefaultUserClaimCreator implementation.

```csharp
public static IServiceCollection AddUserProvider<TUserAccessor, TUserRetrieveService>(
    this IServiceCollection services)
    where TUserAccessor : class, IUserAccessor
    where TUserRetrieveService : class, IUserRetrieveService
```

| parameter | description |
| --- | --- |
| services | The service collection. |

## See Also

* interface [IUserAccessor](../../Serenity.Abstractions/IUserAccessor.md)
* interface [IUserRetrieveService](../../Serenity.Abstractions/IUserRetrieveService.md)
* class [CoreServiceCollectionExtensions](../CoreServiceCollectionExtensions.md)

---

# CoreServiceCollectionExtensions.AddUserProvider&lt;TUserAccessor,TUserRetrieveService,TUserClaimCreator&gt; method (3 of 3)
**namespace:** *[Serenity.Extensions.DependencyInjection](../../README.md#serenity.extensions.dependencyinjection-namespace)*   **assembly**: *[Serenity.Net.Core](../../README.md)*

Adds the [`DefaultUserProvider`](../../Serenity.Services/DefaultUserProvider.md) as [`IUserProvider`](../../Serenity.Abstractions/IUserProvider.md) implementation to the service collection. Also registers the given IUserAccessor, IUserRetrieveService and IUserClaimCreator implementations.

```csharp
public static IServiceCollection 
    AddUserProvider<TUserAccessor, TUserRetrieveService, TUserClaimCreator>(
    this IServiceCollection services)
    where TUserAccessor : class, IUserAccessor
    where TUserRetrieveService : class, IUserRetrieveService
    where TUserClaimCreator : class, IUserClaimCreator
```

| parameter | description |
| --- | --- |
| services | The service collection. |

## See Also

* interface [IUserAccessor](../../Serenity.Abstractions/IUserAccessor.md)
* interface [IUserRetrieveService](../../Serenity.Abstractions/IUserRetrieveService.md)
* interface [IUserClaimCreator](../../Serenity.Abstractions/IUserClaimCreator.md)
* class [CoreServiceCollectionExtensions](../CoreServiceCollectionExtensions.md)