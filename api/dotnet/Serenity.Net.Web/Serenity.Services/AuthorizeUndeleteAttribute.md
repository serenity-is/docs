# AuthorizeUndeleteAttribute class
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Web](../README.md)*

Authorizes access to a service method by reading one of UndeletePermissionAttribute, DeletePermissionAttribute, ModifyPermissionAttribute or ReadPermissionAttribute from the target type, which is usually a Row class.

```csharp
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
public class AuthorizeUndeleteAttribute : ServiceAuthorizeAttribute
```

| parameter | description |
| --- | --- |
| sourceType | The source type. |

## Public Members

| name | description |
| --- | --- |
| [AuthorizeUndeleteAttribute](AuthorizeUndeleteAttribute/AuthorizeUndeleteAttribute.md)(…) | Authorizes access to a service method by reading one of UndeletePermissionAttribute, DeletePermissionAttribute, ModifyPermissionAttribute or ReadPermissionAttribute from the target type, which is usually a Row class. |

## Remarks

Initializes a new instance of the [`AuthorizeUndeleteAttribute`](./AuthorizeUndeleteAttribute.md) class.

## See Also

* class [ServiceAuthorizeAttribute](./ServiceAuthorizeAttribute.md)
* **Source:** *[AuthorizeUndeleteAttribute.cs](https://github.com/serenity-is/Serenity/blob/de1002603cfc02d59089fb21bce26554dfc55916/src/web/Mvc/AuthorizeUndeleteAttribute.cs)*