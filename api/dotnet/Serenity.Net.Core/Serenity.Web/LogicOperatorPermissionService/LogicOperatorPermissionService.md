# LogicOperatorPermissionService constructor
**namespace:** *[Serenity.Web](../../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Net.Core](../../README.md)*

Adds AND OR operator support to any IPermissionService implementation

```csharp
public LogicOperatorPermissionService(IPermissionService permissionService)
```

| parameter | description |
| --- | --- |
| permissionService | Permission service to wrap with AND/OR functionality |

## Remarks

Register this class in your application start, to allow !, &#x7C;, &amp;, () operators in your permission services, e.g.

```csharp
registrar.RegisterInstance<IPermissionService>(new LogicOperatorPermissionService(new MyPermissionService()))
```

Creates a new LogicOperatorPermissionService wrapping passed IPermissionService

## See Also

* interface [IPermissionService](../../Serenity.Abstractions/IPermissionService.md)
* class [LogicOperatorPermissionService](../LogicOperatorPermissionService.md)