# EmailSender.Send method
**namespace:** *[Serenity.Extensions](../../README.md#serenity.extensions-namespace)*   **assembly**: *[Serenity.Extensions](../../README.md)*

Sends the specified email message, either directly, via the configured pickup folder, or by enqueuing it when queueing is enabled.

```csharp
public void Send(MimeMessage message, bool skipQueue)
```

| parameter | description |
| --- | --- |
| message | The email message to send. |
| skipQueue | Whether to bypass the email queue and send directly. |

## See Also

* class [EmailSender](../EmailSender.md)