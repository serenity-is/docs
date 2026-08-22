# TransientGrantingPermissionService class
**namespace:** *[Serenity.Web](../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Decorates an [`IPermissionService`](../Serenity.Abstractions/IPermissionService.md) to support temporarily granting permissions.

```csharp
public class TransientGrantingPermissionService : IPermissionService, ITransientGrantor
```

| parameter | description |
| --- | --- |
| permissionService | The underlying permission service to delegate to when no transient grant is active. |
| requestContext | The accessor that provides per-request storage for the granting stack. |

## Public Members

| name | description |
| --- | --- |
| [TransientGrantingPermissionService](TransientGrantingPermissionService/TransientGrantingPermissionService.md)(…) | Decorates an [`IPermissionService`](../Serenity.Abstractions/IPermissionService.md) to support temporarily granting permissions. |
| [GetGranted](TransientGrantingPermissionService/GetGranted.md)() |  |
| [Grant](TransientGrantingPermissionService/Grant.md)(…) | Temporarily grants the specified permissions. |
| [GrantAll](TransientGrantingPermissionService/GrantAll.md)() | Temporarily grants all permissions. |
| [HasPermission](TransientGrantingPermissionService/HasPermission.md)(…) | Determines whether the current user has the specified permission, taking transient grants into account. |
| [IsAllGranted](TransientGrantingPermissionService/IsAllGranted.md)() |  |
| [UndoGrant](TransientGrantingPermissionService/UndoGrant.md)() | Reverts the most recent [`Grant`](TransientGrantingPermissionService/Grant.md) or [`GrantAll`](TransientGrantingPermissionService/GrantAll.md) operation. |

## Remarks

Register this decorator at application startup to enable temporary permission grants.

```csharp
registrar.RegisterInstance<IPermissionService>(new TransientGrantingPermissionService(new MyPermissionService()))
```

Creates a new instance of the [`TransientGrantingPermissionService`](TransientGrantingPermissionService.md) class wrapping the specified service.

## See Also

* interface [IPermissionService](../Serenity.Abstractions/IPermissionService.md)
* interface [ITransientGrantor](../Serenity.Abstractions/ITransientGrantor.md)
* **Source:** *[TransientGrantingPermissionService.cs](https://github.com/serenity-is/Serenity/blob/a5013fdf777dbbd87589205ddffcb67f18bea673/src/core/Authorization/TransientGrantingPermissionService.cs)*