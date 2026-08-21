# ImpersonatingUserAccessor constructor
**namespace:** *[Serenity.Web](../../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Net.Core](../../README.md)*

Wraps an [`IUserAccessor`](../../Serenity.Abstractions/IUserAccessor.md) and adds support for temporary user impersonation.

```csharp
public ImpersonatingUserAccessor(IUserAccessor userContext, IHttpContextItemsAccessor itemsAccessor)
```

| parameter | description |
| --- | --- |
| userContext | The underlying user accessor to delegate to when no impersonation is active. |
| itemsAccessor | The accessor that provides the per-request item dictionary used to store the impersonation stack. |

## Remarks

Initializes a new instance of the [`ImpersonatingUserAccessor`](../ImpersonatingUserAccessor.md) class that wraps the specified user accessor and adds impersonation support.

## See Also

* interface [IUserAccessor](../../Serenity.Abstractions/IUserAccessor.md)
* interface [IHttpContextItemsAccessor](../../Serenity.Abstractions/IHttpContextItemsAccessor.md)
* class [ImpersonatingUserAccessor](../ImpersonatingUserAccessor.md)