# BaseUserRetrieveService class
**namespace:** *[Serenity.Extensions](../README.md#serenity.extensions-namespace)*   **assembly**: *[Serenity.Extensions](../README.md)*

Base user retrieve service that provides common functionality for user retrieve services.

```csharp
public abstract class BaseUserRetrieveService : IRemoveAll, IRemoveCachedUser, IUserRetrieveService
```

| parameter | description |
| --- | --- |
| cache | Cache |

## Public Members

| name | description |
| --- | --- |
| virtual [ById](BaseUserRetrieveService/ById.md)(…) |  |
| virtual [ByUsername](BaseUserRetrieveService/ByUsername.md)(…) |  |
| virtual [RemoveAll](BaseUserRetrieveService/RemoveAll.md)() |  |
| virtual [RemoveCachedUser](BaseUserRetrieveService/RemoveCachedUser.md)(…) |  |

## Protected Members

| name | description |
| --- | --- |
| [BaseUserRetrieveService](BaseUserRetrieveService/BaseUserRetrieveService.md)(…) | Base user retrieve service that provides common functionality for user retrieve services. |
| virtual [GetCachedById](BaseUserRetrieveService/GetCachedById.md)(…) | Gets the cached user by the specified ID. |
| virtual [GetCachedByUsername](BaseUserRetrieveService/GetCachedByUsername.md)(…) | Gets the cached user by the specified username. |
| virtual [GetCacheDuration](BaseUserRetrieveService/GetCacheDuration.md)() | Gets the cache duration for user retrieval. Default is zero, meaning it will be cached indefinitely unless expired by using the cache group key. |
| abstract [GetCacheGroupKey](BaseUserRetrieveService/GetCacheGroupKey.md)() | Gets the cache group key for user retrieval. |
| virtual [GetIdCacheKey](BaseUserRetrieveService/GetIdCacheKey.md)(…) | Gets the cache key for the specified user ID. |
| virtual [GetUsernameCacheKey](BaseUserRetrieveService/GetUsernameCacheKey.md)(…) | Gets the cache key for the specified username. |
| virtual [IsValidUserId](BaseUserRetrieveService/IsValidUserId.md)(…) | Checks if the specified user ID is valid. By default, it checks if it is not null or empty. |
| virtual [IsValidUsername](BaseUserRetrieveService/IsValidUsername.md)(…) | Checks if the specified username is valid. By default, it checks if it is not null or empty. |
| abstract [LoadById](BaseUserRetrieveService/LoadById.md)(…) | Loads the user by the specified ID from database. |
| abstract [LoadByUsername](BaseUserRetrieveService/LoadByUsername.md)(…) | Loads the user by the specified username from database |

## See Also

* interface [IRemoveAll](../../Serenity.Net.Core/Serenity.Abstractions/IRemoveAll.md)
* interface [IRemoveCachedUser](../../Serenity.Net.Core/Serenity.Abstractions/IRemoveCachedUser.md)
* interface [IUserRetrieveService](../../Serenity.Net.Core/Serenity.Abstractions/IUserRetrieveService.md)
* **Source:** *[BaseUserRetrieveService.cs](https://github.com/serenity-is/Serenity/blob/e8b5b16d9f43821af3cabbbf863eaed415461931/common-features/src/extensions/Modules/Authorization/BaseUserRetrieveService.cs)*