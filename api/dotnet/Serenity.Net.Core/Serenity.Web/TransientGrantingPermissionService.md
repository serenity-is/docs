# TransientGrantingPermissionService class
**namespace:** *[Serenity.Web](../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Adds temporary granting support to any IPermissionService implementation

```csharp
public class TransientGrantingPermissionService : IPermissionService, ITransientGrantor
```

## Public Members

| name | description |
| --- | --- |
| [TransientGrantingPermissionService](TransientGrantingPermissionService/TransientGrantingPermissionService.md)(…) | Creates a new TransientGrantingPermissionService wrapping passed service |
| [Grant](TransientGrantingPermissionService/Grant.md)(…) | Grants specified permissions temporarily (or makes it look like) |
| [GrantAll](TransientGrantingPermissionService/GrantAll.md)() | Grants all permissions temporarily (or makes it look like) |
| [HasPermission](TransientGrantingPermissionService/HasPermission.md)(…) | Checks if user has specified permission |
| [UndoGrant](TransientGrantingPermissionService/UndoGrant.md)() | Undoes last grant or grant all operation |

## Remarks

Register this class in your application start, to allow granting permissions temporarily.

```csharp
registrar.RegisterInstance<IPermissionService>(new TransientGrantingPermissionService(new MyPermissionService()))
```

## See Also

* interface [IPermissionService](../Serenity.Abstractions/IPermissionService.md)
* interface [ITransientGrantor](../Serenity.Abstractions/ITransientGrantor.md)
* **Source:** *[TransientGrantingPermissionService.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Core/Authorization/TransientGrantingPermissionService.cs)*