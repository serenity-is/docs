# UserListOptions class
**namespace:** *[Serenity.Abstractions](../README.md#serenity.abstractions-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Options for listing users with [`IUserListService`](./IUserListService.md).

```csharp
public class UserListOptions
```

## Public Members

| name | description |
| --- | --- |
| [UserListOptions](UserListOptions/UserListOptions.md)() | The default constructor. |
| [ContainsText](UserListOptions/ContainsText.md) { get; set; } | Gets or sets a text that the username or the display name of the users should contain. The username is compared the way the users are looked up by it, which is by its normalized form when the application keeps one, and the display name the way the database compares text, so it is case insensitive with the usual collations. All users match when it is blank. |
| [IncludeInactive](UserListOptions/IncludeInactive.md) { get; set; } | Gets or sets whether to list the users that are disabled too, which is `false` by default. The users that are deleted are never listed, unless they are asked for with [`UserIds`](./UserListOptions/UserIds.md) or [`Usernames`](./UserListOptions/Usernames.md). |
| [Take](UserListOptions/Take.md) { get; set; } | Gets or sets the maximum number of users to list, ordered by username. All users are listed when it is zero or less. |
| [UserIds](UserListOptions/UserIds.md) { get; set; } | Gets or sets the identifiers of the users to list, e.g. to show the usernames of the users that the records of another table refer to, which may be in another database, so they can't be joined. Only these users are listed when it is set, whether they are active or not, as they are asked for by who they are. The ones that are not found or are not valid identifiers are left out. It is no restriction when it is null, and an empty list lists nobody. If [`Usernames`](./UserListOptions/Usernames.md) is set too, the users of either are listed. |
| [Usernames](UserListOptions/Usernames.md) { get; set; } | Gets or sets the usernames of the users to list, e.g. to show their display names. They are compared the way the users are looked up by their usernames, so the case is ignored when the application does so. Only these users are listed when it is set, whether they are active or not, as they are asked for by who they are. It is no restriction when it is null, and an empty list lists nobody. If [`UserIds`](./UserListOptions/UserIds.md) is set too, the users of either are listed. |

## See Also

* **Source:** *[UserListOptions.cs](https://github.com/serenity-is/Serenity/blob/882461e9795b4808b6c6068fb00cfed131e6a69d/src/core/Authorization/UserListOptions.cs)*