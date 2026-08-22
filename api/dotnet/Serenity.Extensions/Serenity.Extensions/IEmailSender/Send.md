# IEmailSender.Send method
**namespace:** *[Serenity.Extensions](../../README.md#serenity.extensions-namespace)*   **assembly**: *[Serenity.Extensions](../../README.md)*

Sends the specified email message.

```csharp
public void Send(MimeMessage message, bool skipQueue = false)
```

| parameter | description |
| --- | --- |
| message | The email message to send. |
| skipQueue | Whether to bypass the email queue and send directly. |

## See Also

* interface [IEmailSender](../IEmailSender.md)