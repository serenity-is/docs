# ListRequestHandler&lt;TRow&gt; class
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Base generic class for list request handlers that use [`ListRequest`](ListRequest.md) as the request type, and [`ListResponse`](ListResponse-1.md) as the response type.

```csharp
public class ListRequestHandler<TRow> : ListRequestHandler<TRow, ListRequest, ListResponse<TRow>>, 
    IListHandler<TRow>, IListHandler<TRow, ListRequest>
    where TRow : class, IRow, new()
```

| parameter | description |
| --- | --- |
| TRow | The entity type |
| context | The request context |

## Public Members

| name | description |
| --- | --- |
| [ListRequestHandler](ListRequestHandler-1/ListRequestHandler.md)(…) | Base generic class for list request handlers that use [`ListRequest`](ListRequest.md) as the request type, and [`ListResponse`](ListResponse-1.md) as the response type. |

## Remarks

Creates an instance of the class

## See Also

* class [ListRequestHandler&lt;TRow,TListRequest,TListResponse&gt;](ListRequestHandler-3.md)
* class [TRow](../Serenity.Net.Services/ListRequestHandler-1.TRow.md)
* class [ListRequest](ListRequest.md)
* class [ListResponse&lt;T&gt;](ListResponse-1.md)
* interface [IListHandler&lt;TRow&gt;](IListHandler-1.md)
* interface [IListHandler&lt;TRow,TListRequest&gt;](IListHandler-2.md)
* interface [IRow](../Serenity.Data/IRow.md)
* **Source:** *[ListRequestHandlerT.cs](https://github.com/serenity-is/Serenity/blob/master/src/Services/RequestHandlers/List/ListRequestHandlerT.cs)*