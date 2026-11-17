# IUserListService interface
**namespace:** *[Serenity.Abstractions](../README.md#serenity.abstractions-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Lists the users of the application, e.g. for the editors that pick users, as [`IUserRetrieveService`](./IUserRetrieveService.md) does not know more than the user it is asked for. It only gives the users, and does not check who is asking, so the services that expose it to the users should have their own permissions, and return only what they need.

```csharp
public interface IUserListService
```

## Members

| name | description |
| --- | --- |
| [ListUsers](IUserListService/ListUsers.md)(…) | Lists the users, ordered by their usernames. |

## See Also

* **Source:** *[IUserListService.cs](https://github.com/serenity-is/Serenity/blob/882461e9795b4808b6c6068fb00cfed131e6a69d/src/core/Authorization/IUserListService.cs)*