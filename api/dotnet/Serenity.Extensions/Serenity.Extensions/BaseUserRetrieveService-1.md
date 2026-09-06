# BaseUserRetrieveService&lt;TRow&gt; class
**namespace:** *[Serenity.Extensions](../README.md#serenity.extensions-namespace)*   **assembly**: *[Serenity.Extensions](../README.md)*

Base user retrieve service that provides common functionality for user retrieve services.

```csharp
public abstract class BaseUserRetrieveService<TRow> : BaseUserRetrieveService
    where TRow : class, IRow, IIdRow, INameRow, new()
```

| parameter | description |
| --- | --- |
| TRow | User row type |
| cache | Cache |
| sqlConnections | SQL connections |

## Protected Members

| name | description |
| --- | --- |
| [BaseUserRetrieveService](BaseUserRetrieveService-1/BaseUserRetrieveService.md)(…) | Base user retrieve service that provides common functionality for user retrieve services. |
| override [GetCacheGroupKey](BaseUserRetrieveService-1/GetCacheGroupKey.md)() | Gets the cache group key for user retrieval. |
| override [IsValidUserId](BaseUserRetrieveService-1/IsValidUserId.md)(…) | Checks if the specified user ID is valid. |
| virtual [LoadByCriteria](BaseUserRetrieveService-1/LoadByCriteria.md)(…) | Loads a user from the database by the specified criteria. |
| override [LoadById](BaseUserRetrieveService-1/LoadById.md)(…) | Loads the user by the specified ID from database. |
| override [LoadByUsername](BaseUserRetrieveService-1/LoadByUsername.md)(…) | Loads the user by the specified username from database. |
| abstract [ToUserDefinition](BaseUserRetrieveService-1/ToUserDefinition.md)(…) | Converts the specified row to a user definition. |

## See Also

* class [BaseUserRetrieveService](./BaseUserRetrieveService.md)
* interface [IRow](../../Serenity.Net.Services/Serenity.Data/IRow.md)
* interface [IIdRow](../../Serenity.Net.Services/Serenity.Data/IIdRow.md)
* interface [INameRow](../../Serenity.Net.Services/Serenity.Data/INameRow.md)
* **Source:** *[BaseUserRetrieveServiceT.cs](https://github.com/serenity-is/Serenity/blob/e8b5b16d9f43821af3cabbbf863eaed415461931/common-features/src/extensions/Modules/Authorization/BaseUserRetrieveServiceT.cs)*