# ListRequestHandlerBase&lt;TRow,TListRequest,TListResponse&gt;.GetHandlerSettings method

Gets the request handler settings (default / maximum page size). The default implementation reads them from an [`IHasHandlerSettings`](../IHasHandlerSettings.md) capable request context, falling back to [`Default`](../RequestHandlerSettings/Default.md) (no limits). Override to return different settings per request / entity, e.g. a limited page size for public access and unlimited for administrators (see [`With`](../RequestHandlerSettings/With.md)).

```csharp
protected virtual RequestHandlerSettings GetHandlerSettings()
```

## Return Value

Request handler settings.

## See Also

* class [RequestHandlerSettings](../RequestHandlerSettings.md)
* class [ListRequestHandlerBase&lt;TRow,TListRequest,TListResponse&gt;](../ListRequestHandlerBase-3.md)