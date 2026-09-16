# ResetPasswordRequest class
**namespace:** *[Serenity.Extensions](../README.md#serenity.extensions-namespace)*   **assembly**: *[Serenity.Extensions](../README.md)*

The request model for a reset password service.

```csharp
public class ResetPasswordRequest : ServiceRequest
```

## Public Members

| name | description |
| --- | --- |
| [ResetPasswordRequest](ResetPasswordRequest/ResetPasswordRequest.md)() | The default constructor. |
| [ConfirmPassword](ResetPasswordRequest/ConfirmPassword.md) { get; set; } | The confirmation of the new password. |
| [NewPassword](ResetPasswordRequest/NewPassword.md) { get; set; } | The new password. |
| [Token](ResetPasswordRequest/Token.md) { get; set; } | The reset token issued when the reset password email was sent. |

## See Also

* class [ServiceRequest](../../Serenity.Net.Services/Serenity.Services/ServiceRequest.md)
* **Source:** *[ResetPasswordRequest.cs](https://github.com/serenity-is/Serenity/blob/f681c4775d515f42ae248938da92305df66f5c02/common-features/src/extensions/Modules/Membership/PasswordActions/ResetPasswordRequest.cs)*