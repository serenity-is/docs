# LogicOperatorPermissionService class
**namespace:** *[Serenity.Web](../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Adds AND OR operator support to any IPermissionService implementation

```csharp
public class LogicOperatorPermissionService : IPermissionService
```

## Public Members

| name | description |
| --- | --- |
| [LogicOperatorPermissionService](LogicOperatorPermissionService/LogicOperatorPermissionService.md)(…) | Creates a new LogicOperatorPermissionService wrapping passed IPermissionService |
| [HasPermission](LogicOperatorPermissionService/HasPermission.md)(…) | Returns true if user has specified permission |

## Remarks

Register this class in your application start, to allow !, &#x7C;, &amp;, () operators in your permission services, e.g.

```csharp
registrar.RegisterInstance<IPermissionService>(new LogicOperatorPermissionService(new MyPermissionService()))
```

## See Also

* interface [IPermissionService](../Serenity.Abstractions/IPermissionService.md)
* **Source:** *[LogicOperatorPermissionService.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Core/Authorization/LogicOperatorPermissionService.cs)*