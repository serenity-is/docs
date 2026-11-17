# RoleDefinitionExtensions class
**namespace:** *[Serenity.Abstractions](../README.md#serenity.abstractions-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Extensions for [`IRoleDefinition`](./IRoleDefinition.md).

```csharp
public static class RoleDefinitionExtensions
```

## Public Members

| name | description |
| --- | --- |
| static [GetKeyOrName](RoleDefinitionExtensions/GetKeyOrName.md)(…) | Gets what identifies the role in the roles of a user and in the permissions of a role, which is its key, or its name when it has no key. The permission key that the users who have the role hold is `Role:` followed by it. |

## See Also

* **Source:** *[RoleDefinitionExtensions.cs](https://github.com/serenity-is/Serenity/blob/882461e9795b4808b6c6068fb00cfed131e6a69d/src/core/Authorization/RoleDefinitionExtensions.cs)*