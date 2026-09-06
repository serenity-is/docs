# LogicOperatorPermissionService class
**namespace:** *[Serenity.Web](../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Decorates an [`IPermissionService`](../Serenity.Abstractions/IPermissionService.md) to support logical operators (`!`, `&`, `|`, parentheses) in permission expressions.

```csharp
public class LogicOperatorPermissionService : IPermissionService, ITransientGrantor
```

| parameter | description |
| --- | --- |
| permissionService | The underlying permission service to delegate simple permission checks to. |

## Public Members

| name | description |
| --- | --- |
| [LogicOperatorPermissionService](LogicOperatorPermissionService/LogicOperatorPermissionService.md)(…) | Decorates an [`IPermissionService`](../Serenity.Abstractions/IPermissionService.md) to support logical operators (`!`, `&`, `|`, parentheses) in permission expressions. |
| [GetGranted](LogicOperatorPermissionService/GetGranted.md)() |  |
| [Grant](LogicOperatorPermissionService/Grant.md)(…) |  |
| [GrantAll](LogicOperatorPermissionService/GrantAll.md)() |  |
| [HasPermission](LogicOperatorPermissionService/HasPermission.md)(…) | Determines whether the current user has the specified permission or satisfies the given logical permission expression. |
| [IsAllGranted](LogicOperatorPermissionService/IsAllGranted.md)() |  |
| [UndoGrant](LogicOperatorPermissionService/UndoGrant.md)() |  |

## Remarks

Register this decorator at application startup to enable expressions such as `PermissionA & !PermissionB`.

```csharp
registrar.RegisterInstance<IPermissionService>(new LogicOperatorPermissionService(new MyPermissionService()))
```

Creates a new instance of the [`LogicOperatorPermissionService`](./LogicOperatorPermissionService.md) class wrapping the specified permission service.

## See Also

* interface [IPermissionService](../Serenity.Abstractions/IPermissionService.md)
* interface [ITransientGrantor](../Serenity.Abstractions/ITransientGrantor.md)
* **Source:** *[LogicOperatorPermissionService.cs](https://github.com/serenity-is/Serenity/blob/a5013fdf777dbbd87589205ddffcb67f18bea673/src/core/Authorization/LogicOperatorPermissionService.cs)*