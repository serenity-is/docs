# TransientGrantingPermissionService constructor
**namespace:** *[Serenity.Web](../../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Net.Core](../../README.md)*

Adds temporary granting support to any IPermissionService implementation

```csharp
public TransientGrantingPermissionService(IPermissionService permissionService = null, 
    IHttpContextItemsAccessor requestContext = null)
```

| parameter | description |
| --- | --- |
| permissionService | Permission service to wrap with transient granting ability |
| requestContext | Request context |

## Remarks

Register this class in your application start, to allow granting permissions temporarily.

```csharp
registrar.RegisterInstance<IPermissionService>(new TransientGrantingPermissionService(new MyPermissionService()))
```

Creates a new TransientGrantingPermissionService wrapping passed service

## See Also

* interface [IPermissionService](../../Serenity.Abstractions/IPermissionService.md)
* interface [IHttpContextItemsAccessor](../../Serenity.Abstractions/IHttpContextItemsAccessor.md)
* class [TransientGrantingPermissionService](../TransientGrantingPermissionService.md)