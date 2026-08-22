# IIsSensitiveMessage interface
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

An interface to determine if the message of an exception might contain sensitive information that should not be shown to the end user. Currently only [`ValidationError`](ValidationError.md) implements this and returns false by default unless set explicitly.

```csharp
public interface IIsSensitiveMessage
```

## Members

| name | description |
| --- | --- |
| [IsSensitiveMessage](IIsSensitiveMessage/IsSensitiveMessage.md) { get; } | Gets a value indicating whether the message of this exception can be safely shown to the end user, e.g. whether it does not contain sensitive information. |

## See Also

* **Source:** *[IIsSensitiveMessage.cs](https://github.com/serenity-is/Serenity/blob/a5013fdf777dbbd87589205ddffcb67f18bea673/src/core/Interface/IIsSensitiveMessage.cs)*