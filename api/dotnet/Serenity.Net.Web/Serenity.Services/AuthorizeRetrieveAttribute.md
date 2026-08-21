# AuthorizeRetrieveAttribute class
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Web](../README.md)*

Authorizes retrieve access to a service method by reading ReadPermissionAttribute.

```csharp
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
public class AuthorizeRetrieveAttribute : ServiceAuthorizeAttribute
```

| parameter | description |
| --- | --- |
| sourceType | The source type. |

## Public Members

| name | description |
| --- | --- |
| [AuthorizeRetrieveAttribute](AuthorizeRetrieveAttribute/AuthorizeRetrieveAttribute.md)(…) | Authorizes retrieve access to a service method by reading ReadPermissionAttribute. |

## Remarks

Initializes a new instance of the [`AuthorizeRetrieveAttribute`](AuthorizeRetrieveAttribute.md) class.

## See Also

* class [ServiceAuthorizeAttribute](ServiceAuthorizeAttribute.md)
* **Source:** *[AuthorizeRetrieveAttribute.cs](https://github.com/serenity-is/Serenity/blob/master/src/Web/Mvc/AuthorizeRetrieveAttribute.cs)*