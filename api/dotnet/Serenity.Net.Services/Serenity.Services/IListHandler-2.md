# IListHandler&lt;TRow,TListRequest&gt; interface
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

```csharp
public interface IListHandler<TRow, TListRequest> : 
    IListHandler<TRow, TListRequest, ListResponse<TRow>>
    where TRow : class, IRow, new()
    where TListRequest : ListRequest
```

## See Also

* interface [IListHandler&lt;TRow,TListRequest,TListResponse&gt;](IListHandler-3.md)
* class [TRow](../Serenity.Net.Services/IListHandler-2.TRow.md)
* class [TListRequest](../Serenity.Net.Services/IListHandler-2.TListRequest.md)
* class [ListResponse&lt;T&gt;](ListResponse-1.md)
* interface [IRow](../Serenity.Net.Entity/../Serenity.Data/IRow.md)
* class [ListRequest](ListRequest.md)
* **Source:** *[IListHandler.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Services/RequestHandlers/List/IListHandler.cs)*