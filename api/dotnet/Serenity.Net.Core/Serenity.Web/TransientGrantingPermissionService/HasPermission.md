# TransientGrantingPermissionService.HasPermission method

Determines whether the current user has the specified permission, taking transient grants into account.

```csharp
public bool HasPermission(string permission)
```

| parameter | description |
| --- | --- |
| permission | The permission key to check. |

## Return Value

`true` if the permission is granted; otherwise `false`.

## See Also

* class [TransientGrantingPermissionService](../TransientGrantingPermissionService.md)