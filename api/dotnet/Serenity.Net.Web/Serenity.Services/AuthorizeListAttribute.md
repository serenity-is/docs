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
| [AuthorizeListAttribute](AuthorizeListAttribute/AuthorizeListAttribute.md)(…) | Initializes a new instance of the [`AuthorizeListAttribute`](AuthorizeListAttribute.md) class. |

## See Also

* class [ServiceAuthorizeAttribute](ServiceAuthorizeAttribute.md)
* **Source:** *[AuthorizeListAttribute.cs](https://github.com/serenity-is/Serenity/blob/a5013fdf777dbbd87589205ddffcb67f18bea673/src/web/Mvc/AuthorizeListAttribute.cs)*