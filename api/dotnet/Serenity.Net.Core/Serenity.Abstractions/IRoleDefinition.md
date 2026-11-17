# IRoleDefinition interface
**namespace:** *[Serenity.Abstractions](../README.md#serenity.abstractions-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

A role of the application, as [`IRoleListService`](./IRoleListService.md) lists them.

```csharp
public interface IRoleDefinition
```

## Members

| name | description |
| --- | --- |
| [Id](IRoleDefinition/Id.md) { get; } | Gets the unique role identifier. |
| [Name](IRoleDefinition/Name.md) { get; } | Gets the name of the role, which is what to show to the users. |
| [RoleKey](IRoleDefinition/RoleKey.md) { get; } | Gets the key of the role, which does not change when the role is renamed, or null if the role has none, so it is known by its name. Use [`GetKeyOrName`](./RoleDefinitionExtensions/GetKeyOrName.md) for what the roles of a user and the permissions of a role are stored with. |

## See Also

* **Source:** *[IRoleDefinition.cs](https://github.com/serenity-is/Serenity/blob/882461e9795b4808b6c6068fb00cfed131e6a69d/src/core/Authorization/IRoleDefinition.cs)*