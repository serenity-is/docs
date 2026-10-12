# IListRequestHandler.HandlerSettings property

Gets the request handler settings, e.g. the default / maximum page size. The default implementation reads them from an [`IHasHandlerSettings`](../IHasHandlerSettings.md) capable request context, falling back to [`Default`](../RequestHandlerSettings/Default.md) (no limits).

```csharp
public RequestHandlerSettings HandlerSettings { get; }
```

## Return Value

Request handler settings.

## See Also

* class [RequestHandlerSettings](../RequestHandlerSettings.md)
* interface [IListRequestHandler](../IListRequestHandler.md)