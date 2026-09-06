# AuthorizationExtensions.RemoveCachedUser method (1 of 2)

Removes the specified user from the cache.

```csharp
public static void RemoveCachedUser(this IUserRetrieveService userRetriever, IUserDefinition? user, 
    ITwoLevelCache? cache)
```

| parameter | description |
| --- | --- |
| userRetriever | The user retrieve service. |
| user | The user definition to invalidate, or `null`. |
| cache | The two-level cache to remove entries from when the service does not handle invalidation itself. |

## Remarks

If *userRetriever* implements [`IRemoveCachedUser`](../../Serenity.Abstractions/IRemoveCachedUser.md), that mechanism is used. Otherwise the user is removed from *cache* by identifier and username when available.

## See Also

* interface [IUserRetrieveService](../../Serenity.Abstractions/IUserRetrieveService.md)
* interface [IUserDefinition](../IUserDefinition.md)
* interface [ITwoLevelCache](../../Serenity.Abstractions/ITwoLevelCache.md)
* class [AuthorizationExtensions](../AuthorizationExtensions.md)

---

# AuthorizationExtensions.RemoveCachedUser method (2 of 2)

Removes a cached user entry by identifier and/or username.

```csharp
public static void RemoveCachedUser(this IUserRetrieveService userRetriever, string? userId, 
    string? username, ITwoLevelCache? cache)
```

| parameter | description |
| --- | --- |
| userRetriever | The user retrieve service. |
| userId | The user identifier, or `null`. |
| username | The username, or `null`. |
| cache | The two-level cache to remove entries from when the service does not handle invalidation itself. |

## Remarks

If *userRetriever* implements [`IRemoveCachedUser`](../../Serenity.Abstractions/IRemoveCachedUser.md), that mechanism is used. Otherwise entries are removed from *cache* by the supplied keys.

## See Also

* interface [IUserRetrieveService](../../Serenity.Abstractions/IUserRetrieveService.md)
* interface [ITwoLevelCache](../../Serenity.Abstractions/ITwoLevelCache.md)
* class [AuthorizationExtensions](../AuthorizationExtensions.md)