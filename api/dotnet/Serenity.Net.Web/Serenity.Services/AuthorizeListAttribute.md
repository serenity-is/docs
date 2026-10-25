# AuthorizeListAttribute class
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Web](../README.md)*

Authorizes access to a service method by reading ReadPermissionAttribute. It also allows lookup mode access (as an OR permission) if the source type has ServiceLookupPermissionAttribute.

```csharp
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
public class AuthorizeListAttribute : ServiceAuthorizeAttribute
```

## Public Members

| name | description |
| --- | --- |
| [AuthorizeListAttribute](AuthorizeListAttribute/AuthorizeListAttribute.md)(…) | Initializes a new instance of the [`AuthorizeListAttribute`](./AuthorizeListAttribute.md) class. |

## See Also

* class [ServiceAuthorizeAttribute](./ServiceAuthorizeAttribute.md)
* **Source:** *[AuthorizeListAttribute.cs](https://github.com/serenity-is/Serenity/blob/b25593854f2e2d2560030f357d1bb7a1cbd85e65/src/web/Mvc/Authorization/AuthorizeListAttribute.cs)*