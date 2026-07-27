# LogicOperatorPermissionService class
**namespace:** *[Serenity.Web](../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Adds AND OR operator support to any IPermissionService implementation

```csharp
public class LogicOperatorPermissionService : IPermissionService, ITransientGrantor
```

| parameter | description |
| --- | --- |
| permissionService | Permission service to wrap with AND/OR functionality |

## Public Members

| name | description |
| --- | --- |
| [LogicOperatorPermissionService](LogicOperatorPermissionService/LogicOperatorPermissionService.md)(…) | Adds AND OR operator support to any IPermissionService implementation |
| [GetGranted](LogicOperatorPermissionService/GetGranted.md)() |  |
| [Grant](LogicOperatorPermissionService/Grant.md)(…) |  |
| [GrantAll](LogicOperatorPermissionService/GrantAll.md)() |  |
| [HasPermission](LogicOperatorPermissionService/HasPermission.md)(…) | Returns true if user has specified permission |
| [IsAllGranted](LogicOperatorPermissionService/IsAllGranted.md)() |  |
| [UndoGrant](LogicOperatorPermissionService/UndoGrant.md)() |  |

## Remarks

Register this class in your application start, to allow !, &#x7C;, &amp;, () operators in your permission services, e.g.

```csharp
registrar.RegisterInstance<IPermissionService>(new LogicOperatorPermissionService(new MyPermissionService()))
```

Creates a new LogicOperatorPermissionService wrapping passed IPermissionService

## See Also

* interface [IPermissionService](../Serenity.Abstractions/IPermissionService.md)
* interface [ITransientGrantor](../Serenity.Abstractions/ITransientGrantor.md)
* **Source:** *[LogicOperatorPermissionService.cs](https://github.com/serenity-is/Serenity/blob/master/src/Core/Authorization/LogicOperatorPermissionService.cs)*