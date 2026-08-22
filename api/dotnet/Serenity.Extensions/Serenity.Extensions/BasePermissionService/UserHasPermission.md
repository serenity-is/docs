# BasePermissionService.UserHasPermission method
**namespace:** *[Serenity.Extensions](../../README.md#serenity.extensions-namespace)*   **assembly**: *[Serenity.Extensions](../../README.md)*

Gets if user has the specified permission directly, not via roles. Returns null if permission is not granted or denied directly.

```csharp
protected abstract bool? UserHasPermission(ClaimsPrincipal user, string permission)
```

| parameter | description |
| --- | --- |
| user | User |
| permission | Permission |

## See Also

* class [BasePermissionService](../BasePermissionService.md)