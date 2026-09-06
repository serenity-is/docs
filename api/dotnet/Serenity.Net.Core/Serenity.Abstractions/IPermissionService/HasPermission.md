# IPermissionService.HasPermission method

Determines whether the current user has the specified permission.

```csharp
public bool HasPermission(string permission)
```

| parameter | description |
| --- | --- |
| permission | The permission key to check, for example `Administration:General`. |

## Return Value

`true` if the user has the permission; otherwise `false`.

## See Also

* interface [IPermissionService](../IPermissionService.md)