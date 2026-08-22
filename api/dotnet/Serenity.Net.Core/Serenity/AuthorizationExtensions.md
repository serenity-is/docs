# AuthorizationExtensions class
**namespace:** *[Serenity](../README.md#serenity-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Provides helper extension methods for authorization, permission checks, and user retrieval.

```csharp
public static class AuthorizationExtensions
```

## Public Members

| name | description |
| --- | --- |
| static [GetIdentifier](AuthorizationExtensions/GetIdentifier.md)(…) | Gets the value of the NameIdentifier claim from the specified principal. |
| static [GetUserDefinition](AuthorizationExtensions/GetUserDefinition.md)(…) | Gets the user definition for the specified principal. (3 methods) |
| static [GetUserDefinition&lt;TUserDefinition&gt;](AuthorizationExtensions/GetUserDefinition.md)(…) | Gets the typed user definition for the specified principal. |
| static [Impersonate](AuthorizationExtensions/Impersonate.md)(…) | Impersonates the user with the specified username. |
| static [IsLoggedIn](AuthorizationExtensions/IsLoggedIn.md)(…) | Determines whether the user accessed via *userAccessor* is authenticated. (2 methods) |
| static [RemoveCachedUser](AuthorizationExtensions/RemoveCachedUser.md)(…) | Removes the specified user from the cache. (2 methods) |
| static [ValidateLoggedIn](AuthorizationExtensions/ValidateLoggedIn.md)(…) | Ensures a user is currently authenticated, throwing a validation error with code `NotLoggedIn` otherwise. |
| static [ValidatePermission](AuthorizationExtensions/ValidatePermission.md)(…) | Ensures the current user has the specified permission, throwing a validation error with code `AccessDenied` otherwise. |

## See Also

* **Source:** *[AuthorizationExtensions.cs](https://github.com/serenity-is/Serenity/blob/a5013fdf777dbbd87589205ddffcb67f18bea673/src/core/Authorization/AuthorizationExtensions.cs)*