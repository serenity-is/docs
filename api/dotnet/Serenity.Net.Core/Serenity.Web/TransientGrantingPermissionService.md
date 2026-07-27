# TransientGrantingPermissionService class
**namespace:** *[Serenity.Web](../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Adds temporary granting support to any IPermissionService implementation

```csharp
public class TransientGrantingPermissionService : IPermissionService, ITransientGrantor
```

| parameter | description |
| --- | --- |
| permissionService | Permission service to wrap with transient granting ability |
| requestContext | Request context |

## Public Members

| name | description |
| --- | --- |
| [TransientGrantingPermissionService](TransientGrantingPermissionService/TransientGrantingPermissionService.md)(…) | Adds temporary granting support to any IPermissionService implementation |
| [GetGranted](TransientGrantingPermissionService/GetGranted.md)() |  |
| [Grant](TransientGrantingPermissionService/Grant.md)(…) | Grants specified permissions temporarily (or makes it look like) |
| [GrantAll](TransientGrantingPermissionService/GrantAll.md)() | Grants all permissions temporarily (or makes it look like) |
| [HasPermission](TransientGrantingPermissionService/HasPermission.md)(…) | Checks if user has specified permission |
| [IsAllGranted](TransientGrantingPermissionService/IsAllGranted.md)() |  |
| [UndoGrant](TransientGrantingPermissionService/UndoGrant.md)() | Undoes last grant or grant all operation |

## Remarks

Register this class in your application start, to allow granting permissions temporarily.

```csharp
registrar.RegisterInstance<IPermissionService>(new TransientGrantingPermissionService(new MyPermissionService()))
```

Creates a new TransientGrantingPermissionService wrapping passed service

## See Also

* interface [IPermissionService](../Serenity.Abstractions/IPermissionService.md)
* interface [ITransientGrantor](../Serenity.Abstractions/ITransientGrantor.md)
* **Source:** *[TransientGrantingPermissionService.cs](https://github.com/serenity-is/Serenity/blob/master/src/Core/Authorization/TransientGrantingPermissionService.cs)*