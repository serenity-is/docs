# LogicOperatorPermissionService.HasPermission method
**namespace:** *[Serenity.Web](../../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Net.Core](../../README.md)*

Determines whether the current user has the specified permission or satisfies the given logical permission expression.

```csharp
public bool HasPermission(string permission)
```

| parameter | description |
| --- | --- |
| permission | The permission key or logical expression (supporting `!`, `&`, `|`, and parentheses). |

## Return Value

`true` if the expression evaluates to granted; otherwise `false`.

## See Also

* class [LogicOperatorPermissionService](../LogicOperatorPermissionService.md)