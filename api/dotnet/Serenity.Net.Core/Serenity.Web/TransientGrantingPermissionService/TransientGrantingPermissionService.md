# TransientGrantingPermissionService constructor

Decorates an [`IPermissionService`](../../Serenity.Abstractions/IPermissionService.md) to support temporarily granting permissions.

```csharp
public TransientGrantingPermissionService(IPermissionService? permissionService = null, 
    IHttpContextItemsAccessor? requestContext = null)
```

| parameter | description |
| --- | --- |
| permissionService | The underlying permission service to delegate to when no transient grant is active. |
| requestContext | The accessor that provides per-request storage for the granting stack. |

## Remarks

Register this decorator at application startup to enable temporary permission grants.

```csharp
registrar.RegisterInstance<IPermissionService>(new TransientGrantingPermissionService(new MyPermissionService()))
```

Creates a new instance of the [`TransientGrantingPermissionService`](../TransientGrantingPermissionService.md) class wrapping the specified service.

## See Also

* interface [IPermissionService](../../Serenity.Abstractions/IPermissionService.md)
* interface [IHttpContextItemsAccessor](../../Serenity.Abstractions/IHttpContextItemsAccessor.md)
* class [TransientGrantingPermissionService](../TransientGrantingPermissionService.md)