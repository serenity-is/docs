# DefaultUserProvider class
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Default implementation of [`IUserProvider`](../Serenity.Abstractions/IUserProvider.md) that delegates to an [`IUserAccessor`](../Serenity.Abstractions/IUserAccessor.md), [`IUserClaimCreator`](../Serenity.Abstractions/IUserClaimCreator.md), and [`IUserRetrieveService`](../Serenity.Abstractions/IUserRetrieveService.md).

```csharp
public class DefaultUserProvider : IUserProvider
```

| parameter | description |
| --- | --- |
| userAccessor | The accessor that provides the current user principal. |
| userClaimCreator | The service used to create principals for impersonation. |
| userRetriever | The service used to retrieve user definitions. |
| cache | The two-level cache used for fallback invalidation when the retrieve service does not implement [`IRemoveCachedUser`](../Serenity.Abstractions/IRemoveCachedUser.md). Optional. |

## Public Members

| name | description |
| --- | --- |
| [DefaultUserProvider](DefaultUserProvider/DefaultUserProvider.md)(…) | Default implementation of [`IUserProvider`](../Serenity.Abstractions/IUserProvider.md) that delegates to an [`IUserAccessor`](../Serenity.Abstractions/IUserAccessor.md), [`IUserClaimCreator`](../Serenity.Abstractions/IUserClaimCreator.md), and [`IUserRetrieveService`](../Serenity.Abstractions/IUserRetrieveService.md). |
| [User](DefaultUserProvider/User.md) { get; } |  |
| [ById](DefaultUserProvider/ById.md)(…) |  |
| [ByUsername](DefaultUserProvider/ByUsername.md)(…) |  |
| [CreatePrincipal](DefaultUserProvider/CreatePrincipal.md)(…) |  |
| [Impersonate](DefaultUserProvider/Impersonate.md)(…) |  |
| [RemoveAll](DefaultUserProvider/RemoveAll.md)() |  |
| [RemoveCachedUser](DefaultUserProvider/RemoveCachedUser.md)(…) |  |
| [UndoImpersonate](DefaultUserProvider/UndoImpersonate.md)() |  |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | *userAccessor*, *userClaimCreator* or *userRetriever* is `null`. |

## Remarks

Creates a new instance of the [`DefaultUserProvider`](DefaultUserProvider.md) class.

## See Also

* interface [IUserProvider](../Serenity.Abstractions/IUserProvider.md)
* **Source:** *[DefaultUserProvider.cs](https://github.com/serenity-is/Serenity/blob/master/src/Core/Authorization/DefaultUserProvider.cs)*