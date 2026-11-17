# IUserListService.ListUsers method

Lists the users, ordered by their usernames.

```csharp
public IReadOnlyList<IUserDefinition> ListUsers(UserListOptions? options = null)
```

| parameter | description |
| --- | --- |
| options | The options, which list all the active users when they are not given. |

## Return Value

The users, which may be limited to some of the properties of a user definition, e.g. without the password.

## See Also

* interface [IUserDefinition](../../Serenity/IUserDefinition.md)
* class [UserListOptions](../UserListOptions.md)
* interface [IUserListService](../IUserListService.md)