# ListRequestHandler&lt;TRow&gt; class
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

```csharp
public class ListRequestHandler<TRow> : ListRequestHandler<TRow, ListRequest, ListResponse<TRow>>, 
    IListHandler<TRow>, IListHandler<TRow, ListRequest>
    where TRow : class, IRow, new()
```

## Public Members

| name | description |
| --- | --- |
| [ListRequestHandler](ListRequestHandler-1/ListRequestHandler.md)(…) |  |

## See Also

* class [ListRequestHandler&lt;TRow,TListRequest,TListResponse&gt;](ListRequestHandler-3.md)
* class [TRow](../Serenity.Net.Services/ListRequestHandler-1.TRow.md)
* class [ListRequest](ListRequest.md)
* class [ListResponse&lt;T&gt;](ListResponse-1.md)
* interface [IListHandler&lt;TRow&gt;](IListHandler-1.md)
* interface [IListHandler&lt;TRow,TListRequest&gt;](IListHandler-2.md)
* interface [IRow](../Serenity.Net.Entity/../Serenity.Data/IRow.md)
* **Source:** *[ListRequestHandlerT.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Services/RequestHandlers/List/ListRequestHandlerT.cs)*