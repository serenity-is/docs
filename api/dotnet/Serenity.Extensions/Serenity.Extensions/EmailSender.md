# EmailSender class
**namespace:** *[Serenity.Extensions](../README.md#serenity.extensions-namespace)*   **assembly**: *[Serenity.Extensions](../README.md)*

Default implementation of [`IEmailSender`](./IEmailSender.md) that sends emails via SMTP, a pickup folder, or an email queue.

```csharp
public class EmailSender : IEmailSender
```

## Public Members

| name | description |
| --- | --- |
| [EmailSender](EmailSender/EmailSender.md)(…) | Default implementation of [`IEmailSender`](./IEmailSender.md) that sends emails via SMTP, a pickup folder, or an email queue. |
| [Send](EmailSender/Send.md)(…) | Sends the specified email message, either directly, via the configured pickup folder, or by enqueuing it when queueing is enabled. |

## See Also

* interface [IEmailSender](./IEmailSender.md)
* **Source:** *[EmailSender.cs](https://github.com/serenity-is/Serenity/blob/f681c4775d515f42ae248938da92305df66f5c02/common-features/src/extensions/Modules/EmailSender/EmailSender.cs)*