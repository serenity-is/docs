# DefaultUserProvider constructor
**namespace:** *[Serenity.Services](../../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Core](../../README.md)*

Default implementation of [`IUserProvider`](../../Serenity.Abstractions/IUserProvider.md) that delegates to an [`IUserAccessor`](../../Serenity.Abstractions/IUserAccessor.md), [`IUserClaimCreator`](../../Serenity.Abstractions/IUserClaimCreator.md), and [`IUserRetrieveService`](../../Serenity.Abstractions/IUserRetrieveService.md).

```csharp
public DefaultUserProvider(IUserAccessor userAccessor, IUserClaimCreator userClaimCreator, 
    IUserRetrieveService userRetriever, ITwoLevelCache cache = null)
```

| parameter | description |
| --- | --- |
| userAccessor | The accessor that provides the current user principal. |
| userClaimCreator | The service used to create principals for impersonation. |
| userRetriever | The service used to retrieve user definitions. |
| cache | The two-level cache used for fallback invalidation when the retrieve service does not implement [`IRemoveCachedUser`](../../Serenity.Abstractions/IRemoveCachedUser.md). Optional. |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | *userAccessor*, *userClaimCreator* or *userRetriever* is `null`. |

## Remarks

Creates a new instance of the [`DefaultUserProvider`](../DefaultUserProvider.md) class.

## See Also

* interface [IUserAccessor](../../Serenity.Abstractions/IUserAccessor.md)
* interface [IUserClaimCreator](../../Serenity.Abstractions/IUserClaimCreator.md)
* interface [IUserRetrieveService](../../Serenity.Abstractions/IUserRetrieveService.md)
* interface [ITwoLevelCache](../../Serenity.Abstractions/ITwoLevelCache.md)
* class [DefaultUserProvider](../DefaultUserProvider.md)