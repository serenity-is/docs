# ServiceEndpoint.OnActionExecutionAsync method
**namespace:** *[Serenity.Services](../../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Web](../../README.md)*

Called before the action method is invoked.

```csharp
public virtual Task OnActionExecutionAsync(ActionExecutingContext context, 
    ActionExecutionDelegate next)
```

| parameter | description |
| --- | --- |
| context | The action executing context. |
| next | The ActionExecutionDelegate to execute. Invoke this delegate in the body of `OnActionExecutionAsync` to continue execution of the action. |

## Return Value

A Task instance.

## See Also

* class [ServiceEndpoint](../ServiceEndpoint.md)