# AuthorizationExtensions class
**namespace:** *[Serenity](../README.md#serenity-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Authorization extension methods

```csharp
public static class AuthorizationExtensions
```

## Public Members

| name | description |
| --- | --- |
| static [GetIdentifier](AuthorizationExtensions/GetIdentifier.md)(…) | Gets name identifier claim from given identity |
| static [GetUserDefinition](AuthorizationExtensions/GetUserDefinition.md)(…) | Gets user definition for given user identity (3 methods) |
| static [GetUserDefinition&lt;TUserDefinition&gt;](AuthorizationExtensions/GetUserDefinition.md)(…) | Gets user definition for given user identity |
| static [Impersonate](AuthorizationExtensions/Impersonate.md)(…) | Impersonates a user by its username. Note that this throws an exception if the user is not found, or the underlying user accessor is not an impersonator. |
| static [IsLoggedIn](AuthorizationExtensions/IsLoggedIn.md)(…) | Returns true if user is logged in (authenticated). (2 methods) |
| static [RemoveCachedUser](AuthorizationExtensions/RemoveCachedUser.md)(…) | Tries to invalidate user in cache if the user retrieve service implements IUserCacheInvalidator. If not, and cache is not null and user is not null, it tries to remove user by id and username from cache. (2 methods) |
| static [ValidateLoggedIn](AuthorizationExtensions/ValidateLoggedIn.md)(…) | Checks if there is a currently logged user and throws a validation error with "NotLoggedIn" error code if not. |
| static [ValidatePermission](AuthorizationExtensions/ValidatePermission.md)(…) | Checks if current user has given permission and throws a validation error with "AccessDenied" error code if not. |

## See Also

* **Source:** *[AuthorizationExtensions.cs](https://github.com/serenity-is/Serenity/blob/master/src/Core/Authorization/AuthorizationExtensions.cs)*