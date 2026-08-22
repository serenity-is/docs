# AccountPasswordActionsPageBase&lt;TUserRow&gt;.ChangePassword method (1 of 2)
**namespace:** *[Serenity.Extensions](../../README.md#serenity.extensions-namespace)*   **assembly**: *[Serenity.Extensions](../../README.md)*

Renders the change password page, or the set password page if the user has no password set.

```csharp
public virtual ActionResult ChangePassword(IUserRetrieveService userRetriever)
```

| parameter | description |
| --- | --- |
| userRetriever | The user retrieve service. |

## Return Value

The change password or set password page result.

## See Also

* interface [IUserRetrieveService](../Serenity.Net.Core/../../Serenity.Abstractions/IUserRetrieveService.md)
* class [AccountPasswordActionsPageBase&lt;TUserRow&gt;](../AccountPasswordActionsPageBase-1.md)

---

# AccountPasswordActionsPageBase&lt;TUserRow&gt;.ChangePassword method (2 of 2)
**namespace:** *[Serenity.Extensions](../../README.md#serenity.extensions-namespace)*   **assembly**: *[Serenity.Extensions](../../README.md)*

Changes the password of the current user after validating the old password and strength.

```csharp
public virtual Result<ServiceResponse> ChangePassword(ChangePasswordRequest request, 
    ITwoLevelCache cache, IUserPasswordValidator passwordValidator, 
    IPasswordStrengthValidator passwordStrengthValidator, IUserRetrieveService userRetriever, 
    IOptions<MembershipSettings> membershipOptions, 
    IOptions<EnvironmentSettings> environmentOptions, ITextLocalizer localizer)
```

| parameter | description |
| --- | --- |
| request | The change password request. |
| cache | The two level cache. |
| passwordValidator | The password validator. |
| passwordStrengthValidator | The password strength validator. |
| userRetriever | The user retrieve service. |
| membershipOptions | The membership settings. |
| environmentOptions | The environment settings. |
| localizer | The text localizer. |

## Return Value

The service response.

## See Also

* class [Result&lt;TResponse&gt;](../Serenity.Net.Web/../../Serenity.Services/Result-1.md)
* class [ServiceResponse](../Serenity.Net.Services/../../Serenity.Services/ServiceResponse.md)
* class [ChangePasswordRequest](../ChangePasswordRequest.md)
* interface [ITwoLevelCache](../Serenity.Net.Core/../../Serenity.Abstractions/ITwoLevelCache.md)
* interface [IUserPasswordValidator](../Serenity.Net.Core/../../Serenity.Abstractions/IUserPasswordValidator.md)
* interface [IPasswordStrengthValidator](../Serenity.Net.Core/../../Serenity.Abstractions/IPasswordStrengthValidator.md)
* interface [IUserRetrieveService](../Serenity.Net.Core/../../Serenity.Abstractions/IUserRetrieveService.md)
* class [MembershipSettings](../MembershipSettings.md)
* class [EnvironmentSettings](../EnvironmentSettings.md)
* interface [ITextLocalizer](../Serenity.Net.Core/../../Serenity/ITextLocalizer.md)
* class [AccountPasswordActionsPageBase&lt;TUserRow&gt;](../AccountPasswordActionsPageBase-1.md)