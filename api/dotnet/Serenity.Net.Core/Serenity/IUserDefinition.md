# IUserDefinition interface
**namespace:** *[Serenity](../README.md#serenity-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Represents the core identity information for a user.

```csharp
public interface IUserDefinition
```

## Members

| name | description |
| --- | --- |
| [DisplayName](IUserDefinition/DisplayName.md) { get; } | Gets the display name of the user, which may be the same as [`Username`](IUserDefinition/Username.md). |
| [Email](IUserDefinition/Email.md) { get; } | Gets the email address of the user. |
| [Id](IUserDefinition/Id.md) { get; } | Gets the unique user identifier. |
| [IsActive](IUserDefinition/IsActive.md) { get; } | Gets a value indicating whether the user is active (1 = active, 0 = disabled, -1 = deleted). |
| [Username](IUserDefinition/Username.md) { get; } | Gets the login name of the user. |

## Remarks

Applications typically implement this interface with an application-specific class (for example, `UserDefinition`) that adds additional properties.

## See Also

* **Source:** *[IUserDefinition.cs](https://github.com/serenity-is/Serenity/blob/a5013fdf777dbbd87589205ddffcb67f18bea673/src/core/Authorization/IUserDefinition.cs)*