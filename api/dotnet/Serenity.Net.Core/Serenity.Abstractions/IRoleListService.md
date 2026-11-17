# IRoleListService interface
**namespace:** *[Serenity.Abstractions](../README.md#serenity.abstractions-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Lists the roles of the application, e.g. for the editors that pick roles. It only gives the roles, and does not check who is asking, so the services that expose it to the users should have their own permissions.

```csharp
public interface IRoleListService
```

## Members

| name | description |
| --- | --- |
| [ListRoles](IRoleListService/ListRoles.md)(…) | Lists the roles, ordered by their names. |

## See Also

* **Source:** *[IRoleListService.cs](https://github.com/serenity-is/Serenity/blob/882461e9795b4808b6c6068fb00cfed131e6a69d/src/core/Authorization/IRoleListService.cs)*