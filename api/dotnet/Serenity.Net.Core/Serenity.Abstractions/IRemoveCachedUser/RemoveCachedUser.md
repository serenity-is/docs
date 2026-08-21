# IRemoveCachedUser.RemoveCachedUser method
**namespace:** *[Serenity.Abstractions](../../README.md#serenity.abstractions-namespace)*   **assembly**: *[Serenity.Net.Core](../../README.md)*

Removes the cached user with the specified identifier and/or username.

```csharp
public void RemoveCachedUser(string userId, string username)
```

| parameter | description |
| --- | --- |
| userId | The user identifier, or `null` to skip removal by identifier. |
| username | The username, or `null` to skip removal by username. |

## See Also

* interface [IRemoveCachedUser](../IRemoveCachedUser.md)