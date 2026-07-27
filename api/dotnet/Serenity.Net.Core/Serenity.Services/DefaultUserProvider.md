# DefaultUserProvider class
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Default implementation for [`IUserProvider`](../Serenity.Abstractions/IUserProvider.md) which is a combination of IUserAccessor and IUserRetrieveService.

```csharp
public class DefaultUserProvider : IUserProvider
```

| parameter | description |
| --- | --- |
| userAccessor | User accessor |
| userClaimCreator | User claim creator |
| userRetriever | User retrieve service |
| cache | Optional cache for graceful invalidation if the IUserRetrieveService does not implement IUser |

## Public Members

| name | description |
| --- | --- |
| [DefaultUserProvider](DefaultUserProvider/DefaultUserProvider.md)(…) | Default implementation for [`IUserProvider`](../Serenity.Abstractions/IUserProvider.md) which is a combination of IUserAccessor and IUserRetrieveService. |
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
| ArgumentNullException |  |

## See Also

* interface [IUserProvider](../Serenity.Abstractions/IUserProvider.md)
* **Source:** *[DefaultUserProvider.cs](https://github.com/serenity-is/Serenity/blob/master/src/Core/Authorization/DefaultUserProvider.cs)*