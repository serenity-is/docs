# IRoleListService.ListRoles method

Lists the roles, ordered by their names.

```csharp
public IReadOnlyList<IRoleDefinition> ListRoles(RoleListOptions? options = null)
```

| parameter | description |
| --- | --- |
| options | The options, which list all the roles when they are not given. |

## Return Value

The roles.

## See Also

* interface [IRoleDefinition](../IRoleDefinition.md)
* class [RoleListOptions](../RoleListOptions.md)
* interface [IRoleListService](../IRoleListService.md)