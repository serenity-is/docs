# ServiceError.Message property
**namespace:** *[Serenity.Services](../../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

The error message. In non-development mode the message might be something generic like "some error occured" if the error itself is not a ValidationError. The detailed error can be seen in exception log.

```csharp
public string Message { get; set; }
```

## See Also

* class [ServiceError](../ServiceError.md)