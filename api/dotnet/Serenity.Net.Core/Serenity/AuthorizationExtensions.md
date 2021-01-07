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
| static [GetUserDefinition](AuthorizationExtensions/GetUserDefinition.md)(…) | Gets user definition for given user identity |
| static [GetUserDefinition&lt;TUserDefinition&gt;](AuthorizationExtensions/GetUserDefinition.md)(…) | Gets user definition for given user identity |
| static [IsLoggedIn](AuthorizationExtensions/IsLoggedIn.md)(…) | Returns true if user is logged in (authenticated). (2 methods) |
| static [ValidateLoggedIn](AuthorizationExtensions/ValidateLoggedIn.md)(…) | Checks if there is a currently logged user and throws a validation error with "NotLoggedIn" error code if not. |
| static [ValidatePermission](AuthorizationExtensions/ValidatePermission.md)(…) | Checks if current user has given permission and throws a validation error with "AccessDenied" error code if not. |

## See Also

* **Source:** *[AuthorizationExtensions.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Core/Authorization/AuthorizationExtensions.cs)*