# TransientGrantingPermissionService constructor
**namespace:** *[Serenity.Web](../../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Net.Core](../../README.md)*

Creates a new TransientGrantingPermissionService wrapping passed service

```csharp
public TransientGrantingPermissionService(IPermissionService permissionService, 
    IHttpContextItemsAccessor requestContext = null)
```

| parameter | description |
| --- | --- |
| permissionService | Permission service to wrap with transient granting ability |
| requestContext | Request context |

## See Also

* interface [IPermissionService](../../Serenity.Abstractions/IPermissionService.md)
* interface [IHttpContextItemsAccessor](../../Serenity.Abstractions/IHttpContextItemsAccessor.md)
* class [TransientGrantingPermissionService](../TransientGrantingPermissionService.md)