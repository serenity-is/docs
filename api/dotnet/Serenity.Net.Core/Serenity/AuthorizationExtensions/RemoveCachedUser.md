# AuthorizationExtensions.RemoveCachedUser method (1 of 2)
**namespace:** *[Serenity](../../README.md#serenity-namespace)*   **assembly**: *[Serenity.Net.Core](../../README.md)*

Tries to invalidate user in cache if the user retrieve service implements IUserCacheInvalidator. If not, and cache is not null and user is not null, it tries to remove user by id and username from cache.

```csharp
public static void RemoveCachedUser(this IUserRetrieveService userRetriever, IUserDefinition user, 
    ITwoLevelCache cache)
```

| parameter | description |
| --- | --- |
| userRetriever | User retrieve service |
| user | User |
| cache | Cache |

## See Also

* interface [IUserRetrieveService](../../Serenity.Abstractions/IUserRetrieveService.md)
* interface [IUserDefinition](../IUserDefinition.md)
* interface [ITwoLevelCache](../../Serenity.Abstractions/ITwoLevelCache.md)
* class [AuthorizationExtensions](../AuthorizationExtensions.md)

---

# AuthorizationExtensions.RemoveCachedUser method (2 of 2)
**namespace:** *[Serenity](../../README.md#serenity-namespace)*   **assembly**: *[Serenity.Net.Core](../../README.md)*

Tries to invalidate user by its id / name if the user retrieve service implements IUserCacheInvalidator. If not, and cache is not null, it tries to remove user by id from cache.

```csharp
public static void RemoveCachedUser(this IUserRetrieveService userRetriever, string userId, 
    string username, ITwoLevelCache cache)
```

| parameter | description |
| --- | --- |
| userRetriever | User retrieve service |
| userId | UserId |
| username | Username |
| cache |  |

## See Also

* interface [IUserRetrieveService](../../Serenity.Abstractions/IUserRetrieveService.md)
* interface [ITwoLevelCache](../../Serenity.Abstractions/ITwoLevelCache.md)
* class [AuthorizationExtensions](../AuthorizationExtensions.md)