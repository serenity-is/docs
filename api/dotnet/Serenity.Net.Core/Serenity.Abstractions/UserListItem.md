# UserListItem class
**namespace:** *[Serenity.Abstractions](../README.md#serenity.abstractions-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

A user in the list of [`IUserListService`](./IUserListService.md), which has only the properties of [`IUserDefinition`](../Serenity/IUserDefinition.md), so nothing like the password of a user is loaded to list them.

```csharp
public class UserListItem : IUserDefinition
```

## Public Members

| name | description |
| --- | --- |
| [UserListItem](UserListItem/UserListItem.md)() | The default constructor. |
| [DisplayName](UserListItem/DisplayName.md) { get; set; } |  |
| [Email](UserListItem/Email.md) { get; set; } |  |
| [Id](UserListItem/Id.md) { get; set; } |  |
| [IsActive](UserListItem/IsActive.md) { get; set; } |  |
| [Username](UserListItem/Username.md) { get; set; } |  |

## See Also

* interface [IUserDefinition](../Serenity/IUserDefinition.md)
* **Source:** *[UserListItem.cs](https://github.com/serenity-is/Serenity/blob/882461e9795b4808b6c6068fb00cfed131e6a69d/src/core/Authorization/UserListItem.cs)*