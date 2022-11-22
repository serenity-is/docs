# ServiceAuthorizeAttribute class
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Web](../README.md)*

Authorizes access to a service action. Optionally checks the permission provided as the first argument. Use special permission key "?" to check for logged-in users, and "*" to allow anyone including anonymous access. This returns a service error instead of raising an exception like PageAuthorize attribute.

```csharp
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
public class ServiceAuthorizeAttribute : Attribute, IResourceFilter
```

## Public Members

| name | description |
| --- | --- |
| [ServiceAuthorizeAttribute](ServiceAuthorizeAttribute/ServiceAuthorizeAttribute.md)() | Creates an instance of the ServiceAuthorizeAttribute. |
| [ServiceAuthorizeAttribute](ServiceAuthorizeAttribute/ServiceAuthorizeAttribute.md)(…) | Creates an instance of the ServiceAuthorizeAttribute, while deriving the permission key from the passed type's ReadPermissionAttribute (4 constructors) |
| [Override](ServiceAuthorizeAttribute/Override.md) { get; set; } | Should this attribute override the controller level attribute if any. The default is true. |
| [Permission](ServiceAuthorizeAttribute/Permission.md) { get; } | The permission key |
| [OnResourceExecuted](ServiceAuthorizeAttribute/OnResourceExecuted.md)(…) |  |
| [OnResourceExecuting](ServiceAuthorizeAttribute/OnResourceExecuting.md)(…) |  |

## Protected Members

| name | description |
| --- | --- |
| [ServiceAuthorizeAttribute](ServiceAuthorizeAttribute/ServiceAuthorizeAttribute.md)(…) | Creates an instance of the service authorize attribute while trying to determine the permission key from one of the permission attribute types the sourceType has. |
| [OrPermission](ServiceAuthorizeAttribute/OrPermission.md) { get; set; } | And optional secondary permission to check by OR, e.g. if this is specified an user does not have the Permission, the user will still be allowed access if he has the OrPermission. |

## See Also

* **Source:** *[ServiceAuthorizeAttribute.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Web/Mvc/ServiceAuthorizeAttribute.cs)*