# AccountPasswordActionsPageBase&lt;TUserRow&gt;.SendResetPassword method
**namespace:** *[Serenity.Extensions](../../README.md#serenity.extensions-namespace)*   **assembly**: *[Serenity.Extensions](../../README.md)*

Sends a reset password email to the current user, or returns a demo link in public demo mode.

```csharp
public virtual ActionResult SendResetPassword(IUserRetrieveService userRetriever, 
    IEmailSender emailSender, ISiteAbsoluteUrl siteAbsoluteUrl, ITwoLevelCache cache, 
    ITextLocalizer localizer)
```

| parameter | description |
| --- | --- |
| userRetriever | The user retrieve service. |
| emailSender | The email sender. |
| siteAbsoluteUrl | The site absolute URL service. |
| cache | The two level cache. |
| localizer | The text localizer. |

## Return Value

The send reset password response.

## See Also

* interface [IUserRetrieveService](../Serenity.Net.Core/../../Serenity.Abstractions/IUserRetrieveService.md)
* interface [IEmailSender](../IEmailSender.md)
* interface [ISiteAbsoluteUrl](../Serenity.Net.Core/../../Serenity.Abstractions/ISiteAbsoluteUrl.md)
* interface [ITwoLevelCache](../Serenity.Net.Core/../../Serenity.Abstractions/ITwoLevelCache.md)
* interface [ITextLocalizer](../Serenity.Net.Core/../../Serenity/ITextLocalizer.md)
* class [AccountPasswordActionsPageBase&lt;TUserRow&gt;](../AccountPasswordActionsPageBase-1.md)