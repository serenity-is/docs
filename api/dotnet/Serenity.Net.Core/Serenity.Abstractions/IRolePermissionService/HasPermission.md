# IRolePermissionService.HasPermission method

Determines whether the specified role has the given permission.

```csharp
public bool HasPermission(string role, string permission)
```

| parameter | description |
| --- | --- |
| role | The role key or name. |
| permission | The permission key to check. |

## Return Value

`true` if the role has the permission; otherwise `false`.

## See Also

* interface [IRolePermissionService](../IRolePermissionService.md)