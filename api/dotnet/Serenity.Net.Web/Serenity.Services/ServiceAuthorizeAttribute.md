# ServiceAuthorizeAttribute class
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Web](../README.md)*

Authorizes access to a service action. Optionally checks the permission provided as the first argument. Use special permission key `?` to check for logged-in users, and `*` to allow anyone including anonymous access. This returns a service error instead of raising an exception like [`PageAuthorizeAttribute`](../Serenity.Web/PageAuthorizeAttribute.md).

```csharp
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
public class ServiceAuthorizeAttribute : Attribute, IResourceFilter
```

## Public Members

| name | description |
| --- | --- |
| [ServiceAuthorizeAttribute](ServiceAuthorizeAttribute/ServiceAuthorizeAttribute.md)() | Initializes a new instance of the [`ServiceAuthorizeAttribute`](ServiceAuthorizeAttribute.md) class. |
| [ServiceAuthorizeAttribute](ServiceAuthorizeAttribute/ServiceAuthorizeAttribute.md)(…) | Initializes an instance of the [`ServiceAuthorizeAttribute`](ServiceAuthorizeAttribute.md) class, while deriving the permission key from the passed type's ReadPermissionAttribute. (4 constructors) |
| [Override](ServiceAuthorizeAttribute/Override.md) { get; set; } | Gets or sets whether this attribute should override the controller level attribute if any. The default is `true`. |
| [Permission](ServiceAuthorizeAttribute/Permission.md) { get; } | Gets the permission key. |
| [OnResourceExecuted](ServiceAuthorizeAttribute/OnResourceExecuted.md)(…) |  |
| [OnResourceExecuting](ServiceAuthorizeAttribute/OnResourceExecuting.md)(…) |  |

## Protected Members

| name | description |
| --- | --- |
| [ServiceAuthorizeAttribute](ServiceAuthorizeAttribute/ServiceAuthorizeAttribute.md)(…) | Initializes an instance of the service authorize attribute while trying to determine the permission key from one of the permission attribute types the source type has. |
| [OrPermission](ServiceAuthorizeAttribute/OrPermission.md) { get; set; } | Gets or sets an optional secondary permission to check by OR, e.g. if this is specified and the user does not have the [`Permission`](ServiceAuthorizeAttribute/Permission.md), the user will still be allowed access if they have the [`OrPermission`](ServiceAuthorizeAttribute/OrPermission.md). |

## See Also

* **Source:** *[ServiceAuthorizeAttribute.cs](https://github.com/serenity-is/Serenity/blob/a5013fdf777dbbd87589205ddffcb67f18bea673/src/web/Mvc/ServiceAuthorizeAttribute.cs)*