# AuthorizeUpdateAttribute class
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Web](../README.md)*

Authorizes access to a service method by reading one of UpdatePermissionAttribute, ModifyPermissionAttribute or ReadPermissionAttribute from the target type, which is usually a Row class.

```csharp
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
public class AuthorizeUpdateAttribute : ServiceAuthorizeAttribute
```

| parameter | description |
| --- | --- |
| sourceType | Source type |

## Public Members

| name | description |
| --- | --- |
| [AuthorizeUpdateAttribute](AuthorizeUpdateAttribute/AuthorizeUpdateAttribute.md)(…) | Authorizes access to a service method by reading one of UpdatePermissionAttribute, ModifyPermissionAttribute or ReadPermissionAttribute from the target type, which is usually a Row class. |

## Remarks

Creates a new instance of the attribute

## See Also

* class [ServiceAuthorizeAttribute](ServiceAuthorizeAttribute.md)
* **Source:** *[AuthorizeUpdateAttribute.cs](https://github.com/serenity-is/Serenity/blob/master/src/Web/Mvc/AuthorizeUpdateAttribute.cs)*