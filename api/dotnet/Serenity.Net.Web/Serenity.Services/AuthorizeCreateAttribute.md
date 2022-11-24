# AuthorizeCreateAttribute class
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Web](../README.md)*

Authorizes access to a service method by reading one of InsertPermissionAttribute, ModifyPermissionAttribute or ReadPermissionAttribute from the target type, which is usually a Row class.

```csharp
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
public class AuthorizeCreateAttribute : ServiceAuthorizeAttribute
```

## Public Members

| name | description |
| --- | --- |
| [AuthorizeCreateAttribute](AuthorizeCreateAttribute/AuthorizeCreateAttribute.md)(…) | Creates a new instance of the attribute |

## See Also

* class [ServiceAuthorizeAttribute](ServiceAuthorizeAttribute.md)
* **Source:** *[AuthorizeCreateAttribute.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Web/Mvc/AuthorizeCreateAttribute.cs)*