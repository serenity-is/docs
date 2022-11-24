# AuthorizeListAttribute class
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Web](../README.md)*

Authorizes access to a service method by reading ReadPermissionAttribute. It also allows lookup mode access (as OrPermission) if the source type has ServiceLookupPermissionAttribute

```csharp
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
public class AuthorizeListAttribute : ServiceAuthorizeAttribute
```

## Public Members

| name | description |
| --- | --- |
| [AuthorizeListAttribute](AuthorizeListAttribute/AuthorizeListAttribute.md)(…) | Creates a new instance of the attribute |

## See Also

* class [ServiceAuthorizeAttribute](ServiceAuthorizeAttribute.md)
* **Source:** *[AuthorizeListAttribute.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Web/Mvc/AuthorizeListAttribute.cs)*