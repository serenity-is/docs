# BaseRoleListService&lt;TRow&gt; class
**namespace:** *[Serenity.Extensions](../README.md#serenity.extensions-namespace)*   **assembly**: *[Serenity.Extensions](../README.md)*

Base role list service that lists the roles from their rows. The name of a role is the name field of the row, and its key is read from it when it has [`IRoleKeyRow`](./IRoleKeyRow.md).

```csharp
public abstract class BaseRoleListService<TRow> : IRoleListService
    where TRow : class, IRow, IIdRow, INameRow, new()
```

| parameter | description |
| --- | --- |
| TRow | Role row type |
| sqlConnections | SQL connections |

## Public Members

| name | description |
| --- | --- |
| virtual [ListRoles](BaseRoleListService-1/ListRoles.md)(…) |  |

## Protected Members

| name | description |
| --- | --- |
| [BaseRoleListService](BaseRoleListService-1/BaseRoleListService.md)(…) | Base role list service that lists the roles from their rows. The name of a role is the name field of the row, and its key is read from it when it has [`IRoleKeyRow`](./IRoleKeyRow.md). |
| virtual [GetCriteria](BaseRoleListService-1/GetCriteria.md)(…) | Gets the criteria of the roles to list, from the options. |
| virtual [ToListItem](BaseRoleListService-1/ToListItem.md)(…) | Converts a row, which has the fields that are selected to list the roles, to a role of the list. |

## See Also

* interface [IRoleListService](../../Serenity.Net.Core/Serenity.Abstractions/IRoleListService.md)
* interface [IRow](../../Serenity.Net.Services/Serenity.Data/IRow.md)
* interface [IIdRow](../../Serenity.Net.Services/Serenity.Data/IIdRow.md)
* interface [INameRow](../../Serenity.Net.Services/Serenity.Data/INameRow.md)
* **Source:** *[BaseRoleListService.cs](https://github.com/serenity-is/Serenity/blob/882461e9795b4808b6c6068fb00cfed131e6a69d/common-features/src/extensions/Modules/Authorization/BaseRoleListService.cs)*