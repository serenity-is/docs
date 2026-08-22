# ChangePasswordRequest class
**namespace:** *[Serenity.Extensions](../README.md#serenity.extensions-namespace)*   **assembly**: *[Serenity.Extensions](../README.md)*

The request model for a change password service.

```csharp
public class ChangePasswordRequest : ServiceRequest
```

## Public Members

| name | description |
| --- | --- |
| [ChangePasswordRequest](ChangePasswordRequest/ChangePasswordRequest.md)() | The default constructor. |
| [ConfirmPassword](ChangePasswordRequest/ConfirmPassword.md) { get; set; } | The confirmation of the new password. |
| [NewPassword](ChangePasswordRequest/NewPassword.md) { get; set; } | The new password. |
| [OldPassword](ChangePasswordRequest/OldPassword.md) { get; set; } | The current password of the user. |

## See Also

* class [ServiceRequest](../Serenity.Net.Services/../Serenity.Services/ServiceRequest.md)
* **Source:** *[ChangePasswordRequest.cs](https://github.com/serenity-is/Serenity/blob/a5013fdf777dbbd87589205ddffcb67f18bea673/common-features/src/extensions/Modules/Membership/PasswordActions/ChangePasswordRequest.cs)*