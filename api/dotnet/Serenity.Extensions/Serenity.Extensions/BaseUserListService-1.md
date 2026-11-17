# BaseUserListService&lt;TRow&gt; class
**namespace:** *[Serenity.Extensions](../README.md#serenity.extensions-namespace)*   **assembly**: *[Serenity.Extensions](../README.md)*

Base user list service that lists the users from their rows. The username is the name field of the row, and the display name, email and active state are read from it when it has IDisplayNameRow, IEmailRow and IIsActiveRow. Only these fields are selected, so nothing like the password hash is loaded.

```csharp
public abstract class BaseUserListService<TRow> : IUserListService
    where TRow : class, IRow, IIdRow, INameRow, new()
```

| parameter | description |
| --- | --- |
| TRow | User row type |
| sqlConnections | SQL connections |

## Public Members

| name | description |
| --- | --- |
| virtual [ListUsers](BaseUserListService-1/ListUsers.md)(…) |  |

## Protected Members

| name | description |
| --- | --- |
| [BaseUserListService](BaseUserListService-1/BaseUserListService.md)(…) | Base user list service that lists the users from their rows. The username is the name field of the row, and the display name, email and active state are read from it when it has IDisplayNameRow, IEmailRow and IIsActiveRow. Only these fields are selected, so nothing like the password hash is loaded. |
| virtual [GetCriteria](BaseUserListService-1/GetCriteria.md)(…) | Gets the criteria of the users to list when they are not asked for by who they are, from the options. |
| virtual [GetTextCriteria](BaseUserListService-1/GetTextCriteria.md)(…) | Gets the criteria for the text that the username or the display name should contain, if there is one. |
| virtual [SelectFields](BaseUserListService-1/SelectFields.md)(…) | Selects the fields that a user of the list has. |
| virtual [ToListItem](BaseUserListService-1/ToListItem.md)(…) | Converts a row, which has the fields selected by [`SelectFields`](./BaseUserListService-1/SelectFields.md), to a user of the list. |
| const [MaxValuesPerQuery](BaseUserListService-1/MaxValuesPerQuery.md) | The number of identifiers or usernames that are asked for with one query, so the number of its parameters stays below what the databases allow. |

## See Also

* interface [IUserListService](../../Serenity.Net.Core/Serenity.Abstractions/IUserListService.md)
* interface [IRow](../../Serenity.Net.Services/Serenity.Data/IRow.md)
* interface [IIdRow](../../Serenity.Net.Services/Serenity.Data/IIdRow.md)
* interface [INameRow](../../Serenity.Net.Services/Serenity.Data/INameRow.md)
* **Source:** *[BaseUserListService.cs](https://github.com/serenity-is/Serenity/blob/882461e9795b4808b6c6068fb00cfed131e6a69d/common-features/src/extensions/Modules/Authorization/BaseUserListService.cs)*