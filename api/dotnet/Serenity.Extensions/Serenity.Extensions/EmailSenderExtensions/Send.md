# EmailSenderExtensions.Send method
**namespace:** *[Serenity.Extensions](../../README.md#serenity.extensions-namespace)*   **assembly**: *[Serenity.Extensions](../../README.md)*

Sends a simple HTML email with the specified subject, body, and recipient.

```csharp
public static void Send(this IEmailSender emailSender, string subject, string body, string mailTo)
```

| parameter | description |
| --- | --- |
| emailSender | The email sender. |
| subject | The email subject. |
| body | The HTML body of the email. |
| mailTo | The recipient email address. |

## See Also

* interface [IEmailSender](../IEmailSender.md)
* class [EmailSenderExtensions](../EmailSenderExtensions.md)