# AccountPasswordActionsPageBase&lt;TUserRow&gt; class
**namespace:** *[Serenity.Extensions](../README.md#serenity.extensions-namespace)*   **assembly**: *[Serenity.Extensions](../README.md)*

Base class for account password action pages, such as change password, set password, forgot password, and reset password.

```csharp
public abstract class AccountPasswordActionsPageBase<TUserRow> : MembershipPageBase<TUserRow>
    where TUserRow : class, IRow, IIdRow, IEmailRow, IPasswordRow, new()
```

## Public Members

| name | description |
| --- | --- |
| virtual [ChangePassword](AccountPasswordActionsPageBase-1/ChangePassword.md)(…) | Renders the change password page, or the set password page if the user has no password set. (2 methods) |
| virtual [ForgotPassword](AccountPasswordActionsPageBase-1/ForgotPassword.md)() | Renders the forgot password page. |
| virtual [ForgotPassword](AccountPasswordActionsPageBase-1/ForgotPassword.md)(…) | Sends a reset password email to the user with the specified email address. |
| virtual [ResetPassword](AccountPasswordActionsPageBase-1/ResetPassword.md)(…) | Validates the reset token and renders the reset password page if it is valid. (2 methods) |
| virtual [SendResetPassword](AccountPasswordActionsPageBase-1/SendResetPassword.md)(…) | Sends a reset password email to the current user, or returns a demo link in public demo mode. |
| [SetPassword](AccountPasswordActionsPageBase-1/SetPassword.md)() | Renders the set password page. |

## Protected Members

| name | description |
| --- | --- |
| [AccountPasswordActionsPageBase](AccountPasswordActionsPageBase-1/AccountPasswordActionsPageBase.md)() | The default constructor. |
| virtual [ModuleFolder](AccountPasswordActionsPageBase-1/ModuleFolder.md) { get; } | The folder containing the password action module scripts. |
| virtual [GenerateResetPasswordToken](AccountPasswordActionsPageBase-1/GenerateResetPasswordToken.md)(…) | Generates a protected reset password token for the specified user. |
| virtual [GetForgotPasswordPageModel](AccountPasswordActionsPageBase-1/GetForgotPasswordPageModel.md)() | Gets the module page model for the forgot password page. |
| virtual [GetResetPasswordPageModel](AccountPasswordActionsPageBase-1/GetResetPasswordPageModel.md)(…) | Gets the module page model for the reset password page. |
| virtual [ModulePath](AccountPasswordActionsPageBase-1/ModulePath.md)(…) | Gets the module script path for the specified key. |

## See Also

* class [MembershipPageBase&lt;TUserRow&gt;](./MembershipPageBase-1.md)
* interface [IRow](../../Serenity.Net.Services/Serenity.Data/IRow.md)
* interface [IIdRow](../../Serenity.Net.Services/Serenity.Data/IIdRow.md)
* interface [IEmailRow](../../Serenity.Net.Services/Serenity.Data/IEmailRow.md)
* interface [IPasswordRow](../../Serenity.Net.Services/Serenity.Data/IPasswordRow.md)
* **Source:** *[AccountPasswordActionsPageBase.cs](https://github.com/serenity-is/Serenity/blob/a5013fdf777dbbd87589205ddffcb67f18bea673/common-features/src/extensions/Modules/Membership/PasswordActions/AccountPasswordActionsPageBase.cs)*