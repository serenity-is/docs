# BasePermissionService&lt;TUserPermissionRow,TUserRoleRow&gt; class
**namespace:** *[Serenity.Extensions](../README.md#serenity.extensions-namespace)*   **assembly**: *[Serenity.Extensions](../README.md)*

Base permission service that provides common functionality for permission services.

```csharp
public abstract class BasePermissionService<TUserPermissionRow, TUserRoleRow> : 
    BasePermissionService
    where TUserPermissionRow : class, IUserPermissionRow, new()
    where TUserRoleRow : class, IUserRoleRow, new()
```

| parameter | description |
| --- | --- |
| TUserPermissionRow | User permission row type |
| TUserRoleRow | User role row type |
| cache | Cache |
| sqlConnections | Sql connections |
| typeSource | Type source |
| userAccessor | User accessor |
| rolePermissions | Role permissions |
| httpContextItemsAccessor | HTTP context items accessor |

## Protected Members

| name | description |
| --- | --- |
| [BasePermissionService](BasePermissionService-2/BasePermissionService.md)(…) | Base permission service that provides common functionality for permission services. |
| virtual [GetCachedUserPermissions](BasePermissionService-2/GetCachedUserPermissions.md)(…) | Gets the cached user permissions. |
| virtual [GetCachedUserRoles](BasePermissionService-2/GetCachedUserRoles.md)(…) | Gets the cached user roles. |
| virtual [GetUserPermissions](BasePermissionService-2/GetUserPermissions.md)(…) | Gets directly assigned permissions for the specified user. |
| virtual [GetUserPermissionsCacheDuration](BasePermissionService-2/GetUserPermissionsCacheDuration.md)() | Gets the cache duration for user permissions. Default is zero, meaning it will be cached indefinitely, unless expired by using the cache group key. |
| virtual [GetUserPermissionsCacheGroupKey](BasePermissionService-2/GetUserPermissionsCacheGroupKey.md)() | Gets the cache group key for user permissions. |
| virtual [GetUserPermissionsCacheKey](BasePermissionService-2/GetUserPermissionsCacheKey.md)(…) | Gets the cache key for user permissions. |
| override [GetUserRoles](BasePermissionService-2/GetUserRoles.md)(…) | Gets the roles of the specified user. |
| virtual [GetUserRolesCacheDuration](BasePermissionService-2/GetUserRolesCacheDuration.md)() | Gets the cache duration for user roles. Default is zero, meaning it will be cached indefinitely, unless expired by using the cache group key. |
| virtual [GetUserRolesCacheGroupKey](BasePermissionService-2/GetUserRolesCacheGroupKey.md)() | Gets the cache group key for user roles. |
| virtual [GetUserRolesCacheKey](BasePermissionService-2/GetUserRolesCacheKey.md)(…) | Gets the cache key for user roles. |
| virtual [LoadUserPermissions](BasePermissionService-2/LoadUserPermissions.md)(…) | Loads user permissions from database. |
| virtual [LoadUserRoles](BasePermissionService-2/LoadUserRoles.md)(…) | Loads user roles from database. |
| override [UserHasPermission](BasePermissionService-2/UserHasPermission.md)(…) |  |

## See Also

* class [BasePermissionService](BasePermissionService.md)
* interface [IUserPermissionRow](../Serenity.Data/IUserPermissionRow.md)
* interface [IUserRoleRow](../Serenity.Data/IUserRoleRow.md)
* **Source:** *[BasePermissionServiceT.cs](https://github.com/serenity-is/Serenity/blob/15879eaa3751e0f78d3225a48cee8aaf7c1259a1/common-features/src/extensions/Modules/Authorization/BasePermissionServiceT.cs)*