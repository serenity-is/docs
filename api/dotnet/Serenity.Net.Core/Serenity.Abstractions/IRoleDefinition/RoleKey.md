# IRoleDefinition.RoleKey property

Gets the key of the role, which does not change when the role is renamed, or null if the role has none, so it is known by its name. Use [`GetKeyOrName`](../RoleDefinitionExtensions/GetKeyOrName.md) for what the roles of a user and the permissions of a role are stored with.

```csharp
public string? RoleKey { get; }
```

## See Also

* interface [IRoleDefinition](../IRoleDefinition.md)