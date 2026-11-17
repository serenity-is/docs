# RoleDefinitionExtensions.GetKeyOrName method

Gets what identifies the role in the roles of a user and in the permissions of a role, which is its key, or its name when it has no key. The permission key that the users who have the role hold is `Role:` followed by it.

```csharp
public static string GetKeyOrName(this IRoleDefinition role)
```

| parameter | description |
| --- | --- |
| role | The role. |

## Return Value

The key of the role, or its name.

## See Also

* interface [IRoleDefinition](../IRoleDefinition.md)
* class [RoleDefinitionExtensions](../RoleDefinitionExtensions.md)