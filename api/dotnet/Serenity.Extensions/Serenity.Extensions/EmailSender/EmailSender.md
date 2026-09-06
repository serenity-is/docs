# EmailSender constructor

Default implementation of [`IEmailSender`](../IEmailSender.md) that sends emails via SMTP, a pickup folder, or an email queue.

```csharp
public EmailSender(IWebHostEnvironment host, IOptions<SmtpSettings> settings, 
    IEmailQueue emailQueue = null)
```

## See Also

* class [SmtpSettings](../SmtpSettings.md)
* interface [IEmailQueue](../IEmailQueue.md)
* class [EmailSender](../EmailSender.md)