# IUserProvider interface
**namespace:** *[Serenity.Abstractions](../README.md#serenity.abstractions-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Abstraction that is a combination of IUserAccessor, IImpersonator, IUserClaimCreator, IUserRetrieveService and IUserCacheInvalidator. Note that although the [`DefaultUserProvider`](../Serenity.Services/DefaultUserProvider.md) implements IImpersonator, its methods may throw exceptions if the underlying IUserAccessor does not implement IImpersonator.

```csharp
public interface IUserProvider : IImpersonator, IRemoveAll, IRemoveCachedUser, IUserAccessor, 
    IUserClaimCreator, IUserRetrieveService
```

## See Also

* interface [IImpersonator](IImpersonator.md)
* interface [IRemoveAll](IRemoveAll.md)
* interface [IRemoveCachedUser](IRemoveCachedUser.md)
* interface [IUserAccessor](IUserAccessor.md)
* interface [IUserClaimCreator](IUserClaimCreator.md)
* interface [IUserRetrieveService](IUserRetrieveService.md)
* **Source:** *[IUserProvider.cs](https://github.com/serenity-is/Serenity/blob/master/src/Core/Authorization/IUserProvider.cs)*