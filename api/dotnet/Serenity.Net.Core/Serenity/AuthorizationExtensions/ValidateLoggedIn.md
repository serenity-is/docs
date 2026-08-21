# AuthorizationExtensions.ValidateLoggedIn method
**namespace:** *[Serenity](../../README.md#serenity-namespace)*   **assembly**: *[Serenity.Net.Core](../../README.md)*

Ensures a user is currently authenticated, throwing a validation error with code `NotLoggedIn` otherwise.

```csharp
public static void ValidateLoggedIn(this IUserAccessor userAccessor, ITextLocalizer localizer)
```

| parameter | description |
| --- | --- |
| userAccessor | The accessor that provides the current user. |
| localizer | The localizer used to produce the error message. |

## Exceptions

| exception | condition |
| --- | --- |
| [ValidationError](../../Serenity.Services/ValidationError.md) | No user is currently authenticated. |

## See Also

* interface [IUserAccessor](../../Serenity.Abstractions/IUserAccessor.md)
* interface [ITextLocalizer](../ITextLocalizer.md)
* class [AuthorizationExtensions](../AuthorizationExtensions.md)