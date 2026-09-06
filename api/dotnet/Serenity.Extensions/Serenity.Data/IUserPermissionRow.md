# IUserPermissionRow interface
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Extensions](../README.md)*

User permission row interface

```csharp
public interface IUserPermissionRow : IRow
```

## Members

| name | description |
| --- | --- |
| [GrantedField](IUserPermissionRow/GrantedField.md) { get; } | Granted field, might be null if not available. Used to optionally revoke permissions granted via roles. |
| [PermissionKeyField](IUserPermissionRow/PermissionKeyField.md) { get; } | Permission key field |
| [UserIdField](IUserPermissionRow/UserIdField.md) { get; } | User ID field |

## See Also

* interface [IRow](../../Serenity.Net.Services/Serenity.Data/IRow.md)
* **Source:** *[IUserPermissionRow.cs](https://github.com/serenity-is/Serenity/blob/e8b5b16d9f43821af3cabbbf863eaed415461931/common-features/src/extensions/Modules/Authorization/IUserPermissionRow.cs)*