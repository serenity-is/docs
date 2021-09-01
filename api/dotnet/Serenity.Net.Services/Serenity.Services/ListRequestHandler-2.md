# ListRequestHandler&lt;TRow,TListRequest&gt; class
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

```csharp
public class ListRequestHandler<TRow, TListRequest> : 
    ListRequestHandler<TRow, TListRequest, ListResponse<TRow>>, IListHandler<TRow, TListRequest>
    where TRow : class, IRow, new()
    where TListRequest : ListRequest
```

## Public Members

| name | description |
| --- | --- |
| [ListRequestHandler](ListRequestHandler-2/ListRequestHandler.md)(…) |  |

## See Also

* class [ListRequestHandler&lt;TRow,TListRequest,TListResponse&gt;](ListRequestHandler-3.md)
* class [TRow](../Serenity.Net.Services/ListRequestHandler-2.TRow.md)
* class [TListRequest](../Serenity.Net.Services/ListRequestHandler-2.TListRequest.md)
* class [ListResponse&lt;T&gt;](ListResponse-1.md)
* interface [IListHandler&lt;TRow,TListRequest&gt;](IListHandler-2.md)
* interface [IRow](../Serenity.Net.Entity/../Serenity.Data/IRow.md)
* class [ListRequest](ListRequest.md)
* **Source:** *[ListRequestHandlerT2.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Services/RequestHandlers/List/ListRequestHandlerT2.cs)*