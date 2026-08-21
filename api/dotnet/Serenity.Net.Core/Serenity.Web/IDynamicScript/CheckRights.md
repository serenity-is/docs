# IDynamicScript.CheckRights method
**namespace:** *[Serenity.Web](../../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Net.Core](../../README.md)*

Checks whether the current user has the permissions required to access this script, throwing an exception if access is not allowed.

```csharp
public void CheckRights(IPermissionService permissions, ITextLocalizer localizer)
```

| parameter | description |
| --- | --- |
| permissions | Permission service used to check the required permissions. |
| localizer | Text localizer |

## See Also

* interface [IPermissionService](../../Serenity.Abstractions/IPermissionService.md)
* interface [ITextLocalizer](../../Serenity/ITextLocalizer.md)
* interface [IDynamicScript](../IDynamicScript.md)