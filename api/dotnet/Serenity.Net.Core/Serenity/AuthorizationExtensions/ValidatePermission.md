# AuthorizationExtensions.ValidatePermission method
**namespace:** *[Serenity](../../README.md#serenity-namespace)*   **assembly**: *[Serenity.Net.Core](../../README.md)*

Checks if current user has given permission and throws a validation error with "AccessDenied" error code if not.

```csharp
public static void ValidatePermission(this IPermissionService permissions, string permission, 
    ITextLocalizer localizer)
```

| parameter | description |
| --- | --- |
| permissions | Permissions service |
| permission | Permission key |
| localizer | Localizer |

## See Also

* interface [IPermissionService](../../Serenity.Abstractions/IPermissionService.md)
* interface [ITextLocalizer](../ITextLocalizer.md)
* class [AuthorizationExtensions](../AuthorizationExtensions.md)