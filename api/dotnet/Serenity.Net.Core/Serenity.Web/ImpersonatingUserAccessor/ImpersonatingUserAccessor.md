# ImpersonatingUserAccessor constructor
**namespace:** *[Serenity.Web](../../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Net.Core](../../README.md)*

Adds impersonation support to any IUserContext implementation

```csharp
public ImpersonatingUserAccessor(IUserAccessor userContext, IHttpContextItemsAccessor itemsAccessor)
```

| parameter | description |
| --- | --- |
| userContext | The user accessor service to wrap with impersonation support. |
| itemsAccessor | Request items accessor |

## Remarks

Initializes a new instance of the [`ImpersonatingUserAccessor`](../ImpersonatingUserAccessor.md) class that wraps passed authorization service and adds impersonation support.

## See Also

* interface [IUserAccessor](../../Serenity.Abstractions/IUserAccessor.md)
* interface [IHttpContextItemsAccessor](../../Serenity.Abstractions/IHttpContextItemsAccessor.md)
* class [ImpersonatingUserAccessor](../ImpersonatingUserAccessor.md)