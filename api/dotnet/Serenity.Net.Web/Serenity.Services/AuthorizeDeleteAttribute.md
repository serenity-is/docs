# AuthorizeDeleteAttribute class
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Web](../README.md)*

Authorizes access to a service method by reading one of DeletePermissionAttribute, ModifyPermissionAttribute or ReadPermissionAttribute from the target type, which is usually a Row class.

```csharp
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
public class AuthorizeDeleteAttribute : ServiceAuthorizeAttribute
```

## Public Members

| name | description |
| --- | --- |
| [AuthorizeDeleteAttribute](AuthorizeDeleteAttribute/AuthorizeDeleteAttribute.md)(…) | Creates a new instance of the attribute |

## See Also

* class [ServiceAuthorizeAttribute](ServiceAuthorizeAttribute.md)
* **Source:** *[AuthorizeDeleteAttribute.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Web/Mvc/AuthorizeDeleteAttribute.cs)*