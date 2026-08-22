# SmtpSettings class
**namespace:** *[Serenity.Extensions](../README.md#serenity.extensions-namespace)*   **assembly**: *[Serenity.Extensions](../README.md)*

Settings for SMTP email sending.

```csharp
public class SmtpSettings
```

## Public Members

| name | description |
| --- | --- |
| [SmtpSettings](SmtpSettings/SmtpSettings.md)() | Initializes a new instance of the [`SmtpSettings`](SmtpSettings.md) class. |
| [AutoUseQueue](SmtpSettings/AutoUseQueue.md) { get; set; } | Whether to automatically enqueue emails instead of sending them directly. |
| [From](SmtpSettings/From.md) { get; set; } | The default sender address used when a message has no From address. |
| [Host](SmtpSettings/Host.md) { get; set; } | The SMTP server host. |
| [Password](SmtpSettings/Password.md) { get; set; } | The password used to authenticate with the SMTP server. |
| [PickupPath](SmtpSettings/PickupPath.md) { get; set; } | The folder where outgoing emails are written when no SMTP host is configured. |
| [Port](SmtpSettings/Port.md) { get; set; } | The SMTP server port. |
| [SecureSocket](SmtpSettings/SecureSocket.md) { get; set; } | The secure socket options used when connecting to the SMTP server. |
| [Username](SmtpSettings/Username.md) { get; set; } | The username used to authenticate with the SMTP server. |
| const [SectionKey](SmtpSettings/SectionKey.md) | Default section key for SMTP settings. |

## See Also

* **Source:** *[SmtpSettings.cs](https://github.com/serenity-is/Serenity/blob/a5013fdf777dbbd87589205ddffcb67f18bea673/common-features/src/extensions/Modules/EmailSender/SmtpSettings.cs)*