# BaseRolePermissionService&lt;TRolePermissionRow&gt; class
**namespace:** *[Serenity.Extensions](../README.md#serenity.extensions-namespace)*   **assembly**: *[Serenity.Extensions](../README.md)*

Base permission service that provides common functionality for permission services.

```csharp
public abstract class BaseRolePermissionService<TRolePermissionRow> : IRolePermissionService
    where TRolePermissionRow : class, IRolePermissionRow, new()
```

| parameter | description |
| --- | --- |
| TRolePermissionRow | Role permission row type |
| cache | Cache |
| sqlConnections | SQL connections |
| typeSource | Type source |

## Public Members

| name | description |
| --- | --- |
| [HasPermission](BaseRolePermissionService-1/HasPermission.md)(…) |  |

## Protected Members

| name | description |
| --- | --- |
| [BaseRolePermissionService](BaseRolePermissionService-1/BaseRolePermissionService.md)(…) | Base permission service that provides common functionality for permission services. |
| virtual [GetCachedRolePermissions](BaseRolePermissionService-1/GetCachedRolePermissions.md)(…) | Gets the role permissions for the specified role. |
| virtual [GetCacheDuration](BaseRolePermissionService-1/GetCacheDuration.md)() | Gets the cache duration for role permissions. Default is zero, meaning it will be cached indefinitely, unless expired by using the cache group key. |
| virtual [GetCacheGroupKey](BaseRolePermissionService-1/GetCacheGroupKey.md)() | Gets the cache group key for role permissions. |
| virtual [GetCacheKey](BaseRolePermissionService-1/GetCacheKey.md)(…) | Gets the cache key for role permissions. |
| virtual [IsValidRoleKeyOrName](BaseRolePermissionService-1/IsValidRoleKeyOrName.md)(…) | Gets whether the specified role is a valid role key or name. By default, a role is valid if it is not null or empty. |
| virtual [LoadRolePermissions](BaseRolePermissionService-1/LoadRolePermissions.md)(…) | Loads role permissions from database. |

## See Also

* interface [IRolePermissionService](../../Serenity.Net.Core/Serenity.Abstractions/IRolePermissionService.md)
* interface [IRolePermissionRow](../Serenity.Data/IRolePermissionRow.md)
* **Source:** *[BaseRolePermissionServiceT.cs](https://github.com/serenity-is/Serenity/blob/47a8f36cd87e4c2377c35f4a9f9c1c4ba0155f61/common-features/src/extensions/Modules/Authorization/BaseRolePermissionServiceT.cs)*