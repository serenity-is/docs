# BasePermissionService constructor
**namespace:** *[Serenity.Extensions](../../README.md#serenity.extensions-namespace)*   **assembly**: *[Serenity.Extensions](../../README.md)*

Base permission service that provides common functionality for permission services.

```csharp
protected BasePermissionService(IUserAccessor userAccessor, IRolePermissionService rolePermissions, 
    IHttpContextItemsAccessor httpContextItemsAccessor = null)
```

| parameter | description |
| --- | --- |
| userAccessor | User accessor |
| rolePermissions | Role permission service |
| httpContextItemsAccessor | HTTP context items accessor |

## See Also

* interface [IUserAccessor](../Serenity.Net.Core/../../Serenity.Abstractions/IUserAccessor.md)
* interface [IRolePermissionService](../Serenity.Net.Core/../../Serenity.Abstractions/IRolePermissionService.md)
* interface [IHttpContextItemsAccessor](../Serenity.Net.Core/../../Serenity.Abstractions/IHttpContextItemsAccessor.md)
* class [BasePermissionService](../BasePermissionService.md)