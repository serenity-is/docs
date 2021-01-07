# IUserDefinition interface
**namespace:** *[Serenity](../README.md#serenity-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

User definition abstraction.

```csharp
public interface IUserDefinition
```

## Members

| name | description |
| --- | --- |
| [DisplayName](IUserDefinition/DisplayName.md) { get; } | Display name for user (can be same with Username) |
| [Email](IUserDefinition/Email.md) { get; } | Email address |
| [Id](IUserDefinition/Id.md) { get; } | User ID |
| [IsActive](IUserDefinition/IsActive.md) { get; } | Is user active (1 = active, 0 = disabled, -1 = deleted) |
| [Username](IUserDefinition/Username.md) { get; } | User login name |

## Remarks

Your application might have a class that implements this interface, e.g. UserDefinition, that has these properties plus some more specific to your app.

## See Also

* **Source:** *[IUserDefinition.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Core/Authorization/IUserDefinition.cs)*