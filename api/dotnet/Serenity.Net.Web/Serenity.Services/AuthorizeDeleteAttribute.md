# AuthorizeDeleteAttribute class
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Web](../README.md)*

Authorizes access to a service method by reading one of DeletePermissionAttribute, ModifyPermissionAttribute or ReadPermissionAttribute from the target type, which is usually a Row class.

```csharp
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
public class AuthorizeDeleteAttribute : ServiceAuthorizeAttribute
```

| parameter | description |
| --- | --- |
| sourceType | Source type |

## Public Members

| name | description |
| --- | --- |
| [AuthorizeDeleteAttribute](AuthorizeDeleteAttribute/AuthorizeDeleteAttribute.md)(…) | Authorizes access to a service method by reading one of DeletePermissionAttribute, ModifyPermissionAttribute or ReadPermissionAttribute from the target type, which is usually a Row class. |

## Remarks

Creates a new instance of the attribute

## See Also

* class [ServiceAuthorizeAttribute](ServiceAuthorizeAttribute.md)
* **Source:** *[AuthorizeDeleteAttribute.cs](https://github.com/serenity-is/Serenity/blob/master/src/Web/Mvc/AuthorizeDeleteAttribute.cs)*