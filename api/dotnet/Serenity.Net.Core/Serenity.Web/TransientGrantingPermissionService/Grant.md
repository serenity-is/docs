# TransientGrantingPermissionService.Grant method
**namespace:** *[Serenity.Web](../../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Net.Core](../../README.md)*

Temporarily grants the specified permissions.

```csharp
public void Grant(params string[] permissions)
```

| parameter | description |
| --- | --- |
| permissions | The permission keys to grant. |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | *permissions* is `null` or empty. |

## See Also

* class [TransientGrantingPermissionService](../TransientGrantingPermissionService.md)