# BasePermissionService&lt;TUserPermissionRow,TUserRoleRow&gt; constructor
**namespace:** *[Serenity.Extensions](../../README.md#serenity.extensions-namespace)*   **assembly**: *[Serenity.Extensions](../../README.md)*

Base permission service that provides common functionality for permission services.

```csharp
protected BasePermissionService(ITwoLevelCache cache, ISqlConnections sqlConnections, 
    ITypeSource typeSource, IUserAccessor userAccessor, IRolePermissionService rolePermissions, 
    IHttpContextItemsAccessor httpContextItemsAccessor = null)
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

## See Also

* interface [ITwoLevelCache](../Serenity.Net.Core/../../Serenity.Abstractions/ITwoLevelCache.md)
* interface [ISqlConnections](../Serenity.Net.Services/../../Serenity.Data/ISqlConnections.md)
* interface [ITypeSource](../Serenity.Net.Core/../../Serenity.Abstractions/ITypeSource.md)
* interface [IUserAccessor](../Serenity.Net.Core/../../Serenity.Abstractions/IUserAccessor.md)
* interface [IRolePermissionService](../Serenity.Net.Core/../../Serenity.Abstractions/IRolePermissionService.md)
* interface [IHttpContextItemsAccessor](../Serenity.Net.Core/../../Serenity.Abstractions/IHttpContextItemsAccessor.md)
* class [BasePermissionService&lt;TUserPermissionRow,TUserRoleRow&gt;](../BasePermissionService-2.md)