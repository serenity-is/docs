# ListRequestHandlerAsync&lt;TRow&gt; class
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Base generic class for async list request handlers that use [`ListRequest`](./ListRequest.md) as the request type, and [`ListResponse`](./ListResponse-1.md) as the response type.

```csharp
public class ListRequestHandlerAsync<TRow> : 
    ListRequestHandlerAsync<TRow, ListRequest, ListResponse<TRow>>, IListHandlerAsync<TRow>
    where TRow : class, IRow, new()
```

| parameter | description |
| --- | --- |
| TRow | The entity type |
| context | The request context |

## Public Members

| name | description |
| --- | --- |
| [ListRequestHandlerAsync](ListRequestHandlerAsync-1/ListRequestHandlerAsync.md)(…) | Base generic class for async list request handlers that use [`ListRequest`](./ListRequest.md) as the request type, and [`ListResponse`](./ListResponse-1.md) as the response type. |

## Remarks

Initializes a new instance of the class.

## See Also

* class [ListRequestHandlerAsync&lt;TRow,TListRequest,TListResponse&gt;](./ListRequestHandlerAsync-3.md)
* class [ListRequest](./ListRequest.md)
* class [ListResponse&lt;T&gt;](./ListResponse-1.md)
* interface [IListHandlerAsync&lt;TRow&gt;](./IListHandlerAsync-1.md)
* interface [IRow](../Serenity.Data/IRow.md)
* **Source:** *[ListRequestHandlerAsyncT.cs](https://github.com/serenity-is/Serenity/blob/6b0ee5bf7cf3317b3c89e88bd6a74f4e510d83c6/src/services/RequestHandlers/List/ListRequestHandlerAsyncT.cs)*