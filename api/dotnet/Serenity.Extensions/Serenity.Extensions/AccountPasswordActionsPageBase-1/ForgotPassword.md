# AccountPasswordActionsPageBase&lt;TUserRow&gt;.ForgotPassword method (1 of 2)
**namespace:** *[Serenity.Extensions](../../README.md#serenity.extensions-namespace)*   **assembly**: *[Serenity.Extensions](../../README.md)*

Renders the forgot password page.

```csharp
public virtual ActionResult ForgotPassword()
```

## Return Value

The forgot password page result.

## See Also

* class [AccountPasswordActionsPageBase&lt;TUserRow&gt;](../AccountPasswordActionsPageBase-1.md)

---

# AccountPasswordActionsPageBase&lt;TUserRow&gt;.ForgotPassword method (2 of 2)
**namespace:** *[Serenity.Extensions](../../README.md#serenity.extensions-namespace)*   **assembly**: *[Serenity.Extensions](../../README.md)*

Sends a reset password email to the user with the specified email address.

```csharp
public virtual Result<ServiceResponse> ForgotPassword(ForgotPasswordRequest request, 
    IEmailSender emailSender, ISiteAbsoluteUrl siteAbsoluteUrl, ITwoLevelCache cache, 
    ITextLocalizer localizer)
```

| parameter | description |
| --- | --- |
| request | The forgot password request. |
| emailSender | The email sender. |
| siteAbsoluteUrl | The site absolute URL service. |
| cache | The two level cache. |
| localizer | The text localizer. |

## Return Value

The service response.

## See Also

* class [Result&lt;TResponse&gt;](../Serenity.Net.Web/../../Serenity.Services/Result-1.md)
* class [ServiceResponse](../Serenity.Net.Services/../../Serenity.Services/ServiceResponse.md)
* class [ForgotPasswordRequest](../ForgotPasswordRequest.md)
* interface [IEmailSender](../IEmailSender.md)
* interface [ISiteAbsoluteUrl](../Serenity.Net.Core/../../Serenity.Abstractions/ISiteAbsoluteUrl.md)
* interface [ITwoLevelCache](../Serenity.Net.Core/../../Serenity.Abstractions/ITwoLevelCache.md)
* interface [ITextLocalizer](../Serenity.Net.Core/../../Serenity/ITextLocalizer.md)
* class [AccountPasswordActionsPageBase&lt;TUserRow&gt;](../AccountPasswordActionsPageBase-1.md)