# AccountPasswordActionsPageBase&lt;TUserRow&gt;.ResetPassword method (1 of 2)
**namespace:** *[Serenity.Extensions](../../README.md#serenity.extensions-namespace)*   **assembly**: *[Serenity.Extensions](../../README.md)*

Validates the reset token and renders the reset password page if it is valid.

```csharp
public virtual IActionResult ResetPassword(string t, ISqlConnections sqlConnections, 
    ITextLocalizer localizer, IOptions<MembershipSettings> options)
```

| parameter | description |
| --- | --- |
| t | The reset token. |
| sqlConnections | The SQL connections. |
| localizer | The text localizer. |
| options | The membership settings. |

## Return Value

The reset password page or an error result.

## See Also

* interface [ISqlConnections](../Serenity.Net.Services/../../Serenity.Data/ISqlConnections.md)
* interface [ITextLocalizer](../Serenity.Net.Core/../../Serenity/ITextLocalizer.md)
* class [MembershipSettings](../MembershipSettings.md)
* class [AccountPasswordActionsPageBase&lt;TUserRow&gt;](../AccountPasswordActionsPageBase-1.md)

---

# AccountPasswordActionsPageBase&lt;TUserRow&gt;.ResetPassword method (2 of 2)
**namespace:** *[Serenity.Extensions](../../README.md#serenity.extensions-namespace)*   **assembly**: *[Serenity.Extensions](../../README.md)*

Resets the password of the user identified by the reset token.

```csharp
public virtual Result<ResetPasswordResponse> ResetPassword(ResetPasswordRequest request, 
    ITwoLevelCache cache, ISqlConnections sqlConnections, ITextLocalizer localizer, 
    IPasswordStrengthValidator passwordStrengthValidator, 
    IOptions<EnvironmentSettings> environmentOptions, 
    IOptions<MembershipSettings> membershipOptions)
```

| parameter | description |
| --- | --- |
| request | The reset password request. |
| cache | The two level cache. |
| sqlConnections | The SQL connections. |
| localizer | The text localizer. |
| passwordStrengthValidator | The password strength validator. |
| environmentOptions | The environment settings. |
| membershipOptions | The membership settings. |

## Return Value

The reset password response.

## See Also

* class [Result&lt;TResponse&gt;](../Serenity.Net.Web/../../Serenity.Services/Result-1.md)
* class [ResetPasswordResponse](../ResetPasswordResponse.md)
* class [ResetPasswordRequest](../ResetPasswordRequest.md)
* interface [ITwoLevelCache](../Serenity.Net.Core/../../Serenity.Abstractions/ITwoLevelCache.md)
* interface [ISqlConnections](../Serenity.Net.Services/../../Serenity.Data/ISqlConnections.md)
* interface [ITextLocalizer](../Serenity.Net.Core/../../Serenity/ITextLocalizer.md)
* interface [IPasswordStrengthValidator](../Serenity.Net.Core/../../Serenity.Abstractions/IPasswordStrengthValidator.md)
* class [EnvironmentSettings](../EnvironmentSettings.md)
* class [MembershipSettings](../MembershipSettings.md)
* class [AccountPasswordActionsPageBase&lt;TUserRow&gt;](../AccountPasswordActionsPageBase-1.md)