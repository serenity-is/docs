# ServiceEndpoint.OnActionExecutedAsync method

Called after the action method is invoked asynchronously.

```csharp
protected virtual Task OnActionExecutedAsync(ActionExecutedContext context)
```

| parameter | description |
| --- | --- |
| context | The action executed context. |

## Remarks

This is the async IAsyncActionFilter implementation and is the one normally called by MVC. Override this method instead of [`OnActionExecuted`](./OnActionExecuted.md).

## See Also

* class [ServiceEndpoint](../ServiceEndpoint.md)