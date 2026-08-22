# AuthorizeUpdateAttribute class
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Web](../README.md)*

Authorizes access to a service method by reading one of UpdatePermissionAttribute, ModifyPermissionAttribute or ReadPermissionAttribute from the target type, which is usually a Row class.

```csharp
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
public class AuthorizeUpdateAttribute : ServiceAuthorizeAttribute
```

| parameter | description |
| --- | --- |
| sourceType | The source type. |

## Public Members

| name | description |
| --- | --- |
| [AuthorizeUpdateAttribute](AuthorizeUpdateAttribute/AuthorizeUpdateAttribute.md)(…) | Authorizes access to a service method by reading one of UpdatePermissionAttribute, ModifyPermissionAttribute or ReadPermissionAttribute from the target type, which is usually a Row class. |

## Remarks

Initializes a new instance of the [`AuthorizeUpdateAttribute`](AuthorizeUpdateAttribute.md) class.

## See Also

* class [ServiceAuthorizeAttribute](ServiceAuthorizeAttribute.md)
* **Source:** *[AuthorizeUpdateAttribute.cs](https://github.com/serenity-is/Serenity/blob/a5013fdf777dbbd87589205ddffcb67f18bea673/src/web/Mvc/AuthorizeUpdateAttribute.cs)*