# AuthorizationExtensions.ValidatePermission method

Ensures the current user has the specified permission, throwing a validation error with code `AccessDenied` otherwise.

```csharp
public static void ValidatePermission(this IPermissionService permissions, string permission, 
    ITextLocalizer localizer)
```

| parameter | description |
| --- | --- |
| permissions | The permission service to query. |
| permission | The required permission key. |
| localizer | The localizer used to produce the error message. |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | *permissions* is `null`. |
| [ValidationError](../../Serenity.Services/ValidationError.md) | The current user does not have the required permission. |

## See Also

* interface [IPermissionService](../../Serenity.Abstractions/IPermissionService.md)
* interface [ITextLocalizer](../ITextLocalizer.md)
* class [AuthorizationExtensions](../AuthorizationExtensions.md)