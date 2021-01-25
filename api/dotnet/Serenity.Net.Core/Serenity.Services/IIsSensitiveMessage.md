# IIsSensitiveMessage interface
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

An interface to determine if the message of an exception might contain sensitive information that should not be shown to the end user. Currently only ValidationError implements this and returns false by default unless set explicitly.

```csharp
public interface IIsSensitiveMessage
```

## Members

| name | description |
| --- | --- |
| [IsSensitiveMessage](IIsSensitiveMessage/IsSensitiveMessage.md) { get; } | Gets if the message of this exception can be safely shown to the end user, e.g. |

## See Also

* **Source:** *[IIsSensitiveMessage.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Core/Interface/IIsSensitiveMessage.cs)*