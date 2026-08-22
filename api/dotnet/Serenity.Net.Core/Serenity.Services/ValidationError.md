# ValidationError class
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Generic validation error mostly used by services.

```csharp
public class ValidationError : Exception, IIsSensitiveMessage
```

## Public Members

| name | description |
| --- | --- |
| [ValidationError](ValidationError/ValidationError.md)() | Initializes a new instance of the [`ValidationError`](ValidationError.md) class. |
| [ValidationError](ValidationError/ValidationError.md)(…) | Initializes a new instance of the [`ValidationError`](ValidationError.md) class. (8 constructors) |
| [Arguments](ValidationError/Arguments.md) { get; set; } | Gets or sets the arguments. |
| [ErrorCode](ValidationError/ErrorCode.md) { get; set; } | Gets or sets the error code. |
| [IsSensitiveMessage](ValidationError/IsSensitiveMessage.md) { get; set; } | By default all ValidationErrors are end user exceptions (e.g. message can be shown safely to the end user) |

## See Also

* interface [IIsSensitiveMessage](IIsSensitiveMessage.md)
* **Source:** *[ValidationError.cs](https://github.com/serenity-is/Serenity/blob/9b68f558f65ad5d3b8a8af7351efe4622dff626f/src/core/Interface/ValidationError.cs)*