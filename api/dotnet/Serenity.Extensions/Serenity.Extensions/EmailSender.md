# EmailSender class
**namespace:** *[Serenity.Extensions](../README.md#serenity.extensions-namespace)*   **assembly**: *[Serenity.Extensions](../README.md)*

Default implementation of [`IEmailSender`](IEmailSender.md) that sends emails via SMTP, a pickup folder, or an email queue.

```csharp
public class EmailSender : IEmailSender
```

## Public Members

| name | description |
| --- | --- |
| [EmailSender](EmailSender/EmailSender.md)(…) | Default implementation of [`IEmailSender`](IEmailSender.md) that sends emails via SMTP, a pickup folder, or an email queue. |
| [Send](EmailSender/Send.md)(…) | Sends the specified email message, either directly, via the configured pickup folder, or by enqueuing it when queueing is enabled. |

## See Also

* interface [IEmailSender](IEmailSender.md)
* **Source:** *[EmailSender.cs](https://github.com/serenity-is/Serenity/blob/a5013fdf777dbbd87589205ddffcb67f18bea673/common-features/src/extensions/Modules/EmailSender/EmailSender.cs)*