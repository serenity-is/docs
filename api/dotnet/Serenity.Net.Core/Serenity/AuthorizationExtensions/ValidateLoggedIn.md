# AuthorizationExtensions.ValidateLoggedIn method
**namespace:** *[Serenity](../../README.md#serenity-namespace)*   **assembly**: *[Serenity.Net.Core](../../README.md)*

Checks if there is a currently logged user and throws a validation error with "NotLoggedIn" error code if not.

```csharp
public static void ValidateLoggedIn(this IUserAccessor userAccessor, ITextLocalizer localizer)
```

## See Also

* interface [IUserAccessor](../../Serenity.Abstractions/IUserAccessor.md)
* interface [ITextLocalizer](../ITextLocalizer.md)
* class [AuthorizationExtensions](../AuthorizationExtensions.md)