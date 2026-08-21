# LogicOperatorPermissionService constructor
**namespace:** *[Serenity.Web](../../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Net.Core](../../README.md)*

Decorates an [`IPermissionService`](../../Serenity.Abstractions/IPermissionService.md) to support logical operators (`!`, `&`, `|`, parentheses) in permission expressions.

```csharp
public LogicOperatorPermissionService(IPermissionService permissionService)
```

| parameter | description |
| --- | --- |
| permissionService | The underlying permission service to delegate simple permission checks to. |

## Remarks

Register this decorator at application startup to enable expressions such as `PermissionA & !PermissionB`.

```csharp
registrar.RegisterInstance<IPermissionService>(new LogicOperatorPermissionService(new MyPermissionService()))
```

Creates a new instance of the [`LogicOperatorPermissionService`](../LogicOperatorPermissionService.md) class wrapping the specified permission service.

## See Also

* interface [IPermissionService](../../Serenity.Abstractions/IPermissionService.md)
* class [LogicOperatorPermissionService](../LogicOperatorPermissionService.md)