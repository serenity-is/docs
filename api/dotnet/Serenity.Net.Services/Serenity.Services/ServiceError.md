# ServiceError class
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

The error object model returned from a service

```csharp
public class ServiceError
```

## Public Members

| name | description |
| --- | --- |
| [ServiceError](ServiceError/ServiceError.md)() | The default constructor. |
| [Arguments](ServiceError/Arguments.md) { get; set; } | Custom arguments info for the error. In some cases, this might be the field name the error is related to. |
| [Code](ServiceError/Code.md) { get; set; } | Error code if any |
| [Details](ServiceError/Details.md) { get; set; } | Error details, like stack trace etc. Normally, this is only returned in development mode. |
| [ErrorId](ServiceError/ErrorId.md) { get; set; } | When provided, this might be the related error ID stored in the exception log. |
| [Message](ServiceError/Message.md) { get; set; } | The error message. In non-development mode the message might be something generic like "some error occured" if the error itself is not a ValidationError. The detailed error can be seen in exception log. |

## See Also

* **Source:** *[ServiceError.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Services/Models/ServiceError.cs)*