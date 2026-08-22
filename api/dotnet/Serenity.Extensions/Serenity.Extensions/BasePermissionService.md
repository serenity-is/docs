# BasePermissionService class
**namespace:** *[Serenity.Extensions](../README.md#serenity.extensions-namespace)*   **assembly**: *[Serenity.Extensions](../README.md)*

Base permission service that provides common functionality for permission services.

```csharp
public abstract class BasePermissionService : IPermissionService, ITransientGrantor
```

| parameter | description |
| --- | --- |
| userAccessor | User accessor |
| rolePermissions | Role permission service |
| httpContextItemsAccessor | HTTP context items accessor |

## Public Members

| name | description |
| --- | --- |
| virtual [GetGranted](BasePermissionService/GetGranted.md)() |  |
| virtual [Grant](BasePermissionService/Grant.md)(…) |  |
| virtual [GrantAll](BasePermissionService/GrantAll.md)() |  |
| virtual [HasPermission](BasePermissionService/HasPermission.md)(…) |  |
| virtual [IsAllGranted](BasePermissionService/IsAllGranted.md)() |  |
| virtual [UndoGrant](BasePermissionService/UndoGrant.md)() |  |
| static [GetImplicitPermissions](BasePermissionService/GetImplicitPermissions.md)(…) | Gets implicit permissions defined in the application. |

## Protected Members

| name | description |
| --- | --- |
| [BasePermissionService](BasePermissionService/BasePermissionService.md)(…) | Base permission service that provides common functionality for permission services. |
| virtual [AnonymousUsersHavePermission](BasePermissionService/AnonymousUsersHavePermission.md)(…) | Checks if anonymous users have the specified permission. By default, they don't have any permission. |
| abstract [GetUserRoles](BasePermissionService/GetUserRoles.md)(…) | Gets the roles of the specified user. |
| virtual [HasImpersonationPermission](BasePermissionService/HasImpersonationPermission.md)(…) | Returns true if the provided user has the permission to impersonate as another user. Unless overridden, no user have this permission. |
| virtual [IsAsterisk](BasePermissionService/IsAsterisk.md)(…) | Gets whether the specified permission is an asterisk, e.g. "*" that grants permission to all including anonymous users. |
| virtual [IsDeny](BasePermissionService/IsDeny.md)(…) | Gets whether the specified permission is "DENY", which denies access to all users including super administrators. |
| virtual [IsImpersonationPermission](BasePermissionService/IsImpersonationPermission.md)(…) | Gets whether the specified permission is an impersonation permission. By default, impersonation permissions are permissions that start with "ImpersonateAs". |
| virtual [IsQuestionMark](BasePermissionService/IsQuestionMark.md)(…) | Gets whether the specified permission is a question mark, e.g. "?" that grants permission to logged in users. |
| virtual [IsSuperAdmin](BasePermissionService/IsSuperAdmin.md)(…) | Gets whether the specified user is a super admin. |
| virtual [IsTransientlyGranted](BasePermissionService/IsTransientlyGranted.md)(…) | Checks if the transient grantor has the specified permission. |
| virtual [IsValidKey](BasePermissionService/IsValidKey.md)(…) | Gets whether the specified permission is a valid permission key. By default, a permission key is valid if it is not null or empty. |
| virtual [SuperAdminHasPermission](BasePermissionService/SuperAdminHasPermission.md)(…) | Checks if the super admin has the specified permission. By default, super admin has all permissions. |
| abstract [UserHasPermission](BasePermissionService/UserHasPermission.md)(…) | Gets if user has the specified permission directly, not via roles. Returns null if permission is not granted or denied directly. |

## See Also

* interface [IPermissionService](../Serenity.Net.Core/../Serenity.Abstractions/IPermissionService.md)
* interface [ITransientGrantor](../Serenity.Net.Core/../Serenity.Abstractions/ITransientGrantor.md)
* **Source:** *[BasePermissionService.cs](https://github.com/serenity-is/Serenity/blob/47a8f36cd87e4c2377c35f4a9f9c1c4ba0155f61/common-features/src/extensions/Modules/Authorization/BasePermissionService.cs)*