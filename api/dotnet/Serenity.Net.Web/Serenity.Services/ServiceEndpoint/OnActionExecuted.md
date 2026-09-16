# ServiceEndpoint.OnActionExecuted method

Called after the action method is invoked.

```csharp
public virtual void OnActionExecuted(ActionExecutedContext context)
```

| parameter | description |
| --- | --- |
| context | The action executed context. |

## Remarks

This is the synchronous IActionFilter implementation and is normally not called by MVC, as [`ServiceEndpoint`](../ServiceEndpoint.md) also implements IAsyncActionFilter and the async filter is preferred. Unless you are explicitly invoking the synchronous filter pipeline, override [`OnActionExecutedAsync`](./OnActionExecutedAsync.md) instead.

## See Also

* class [ServiceEndpoint](../ServiceEndpoint.md)