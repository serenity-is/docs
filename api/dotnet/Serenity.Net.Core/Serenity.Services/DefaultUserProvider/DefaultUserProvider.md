# DefaultUserProvider constructor
**namespace:** *[Serenity.Services](../../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Core](../../README.md)*

Default implementation for [`IUserProvider`](../../Serenity.Abstractions/IUserProvider.md) which is a combination of IUserAccessor and IUserRetrieveService.

```csharp
public DefaultUserProvider(IUserAccessor userAccessor, IUserClaimCreator userClaimCreator, 
    IUserRetrieveService userRetriever, ITwoLevelCache cache = null)
```

| parameter | description |
| --- | --- |
| userAccessor | User accessor |
| userClaimCreator | User claim creator |
| userRetriever | User retrieve service |
| cache | Optional cache for graceful invalidation if the IUserRetrieveService does not implement IUser |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException |  |

## See Also

* interface [IUserAccessor](../../Serenity.Abstractions/IUserAccessor.md)
* interface [IUserClaimCreator](../../Serenity.Abstractions/IUserClaimCreator.md)
* interface [IUserRetrieveService](../../Serenity.Abstractions/IUserRetrieveService.md)
* interface [ITwoLevelCache](../../Serenity.Abstractions/ITwoLevelCache.md)
* class [DefaultUserProvider](../DefaultUserProvider.md)