# IUserProvider interface
**namespace:** *[Serenity.Abstractions](../README.md#serenity.abstractions-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Combines user access, retrieval, claim creation, impersonation, and cache invalidation into a single abstraction.

```csharp
public interface IUserProvider : IImpersonator, IRemoveAll, IRemoveCachedUser, IUserAccessor, 
    IUserClaimCreator, IUserRetrieveService
```

## Remarks

Although [`DefaultUserProvider`](../Serenity.Services/DefaultUserProvider.md) implements [`IImpersonator`](./IImpersonator.md), its impersonation methods may throw InvalidOperationException when the underlying [`IUserAccessor`](./IUserAccessor.md) does not implement [`IImpersonator`](./IImpersonator.md).

## See Also

* interface [IImpersonator](./IImpersonator.md)
* interface [IRemoveAll](./IRemoveAll.md)
* interface [IRemoveCachedUser](./IRemoveCachedUser.md)
* interface [IUserAccessor](./IUserAccessor.md)
* interface [IUserClaimCreator](./IUserClaimCreator.md)
* interface [IUserRetrieveService](./IUserRetrieveService.md)
* **Source:** *[IUserProvider.cs](https://github.com/serenity-is/Serenity/blob/a5013fdf777dbbd87589205ddffcb67f18bea673/src/core/Authorization/IUserProvider.cs)*