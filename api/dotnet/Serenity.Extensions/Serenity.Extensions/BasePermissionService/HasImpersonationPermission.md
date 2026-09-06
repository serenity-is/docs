# BasePermissionService.HasImpersonationPermission method

Returns true if the provided user has the permission to impersonate as another user. Unless overridden, no user have this permission.

```csharp
protected virtual bool HasImpersonationPermission(ClaimsPrincipal user, string permission)
```

| parameter | description |
| --- | --- |
| user | User |
| permission | Permission |

## See Also

* class [BasePermissionService](../BasePermissionService.md)