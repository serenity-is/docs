# ListQueryCaptureExtensions.GetQueryCapture method

Gets the query capture capability of a list handler, looking through the sync / async wrappers the handler factory may return, or null if the handler can't capture its query. A synchronous handler's capture is adapted to the async interface.

```csharp
public static IListQueryCaptureAsync? GetQueryCapture(this IListRequestHandler handler)
```

| parameter | description |
| --- | --- |
| handler | List handler, e.g. one returned by the handler factory |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | *handler* is null. |

## See Also

* interface [IListQueryCaptureAsync](../IListQueryCaptureAsync.md)
* interface [IListRequestHandler](../IListRequestHandler.md)
* class [ListQueryCaptureExtensions](../ListQueryCaptureExtensions.md)