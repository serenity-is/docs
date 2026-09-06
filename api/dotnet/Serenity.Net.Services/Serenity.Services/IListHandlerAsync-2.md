# IListHandlerAsync&lt;TRow,TListRequest&gt; interface
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Interface for async list request handlers with a custom list request type.

```csharp
public interface IListHandlerAsync<TRow, TListRequest> : 
    IListHandlerAsync<TRow, TListRequest, ListResponse<TRow>>
    where TRow : class, IRow, new()
    where TListRequest : ListRequest
```

| parameter | description |
| --- | --- |
| TRow | Row type |
| TListRequest | List request type |

## See Also

* interface [IListHandlerAsync&lt;TRow,TListRequest,TListResponse&gt;](IListHandlerAsync-3.md)
* class [TRow](../Serenity.Net.Services/IListHandlerAsync-2.TRow.md)
* class [TListRequest](../Serenity.Net.Services/IListHandlerAsync-2.TListRequest.md)
* class [ListResponse&lt;T&gt;](ListResponse-1.md)
* interface [IRow](../Serenity.Data/IRow.md)
* class [ListRequest](ListRequest.md)
* **Source:** *[IListHandlerAsyncT2.cs](https://github.com/serenity-is/Serenity/blob/6b0ee5bf7cf3317b3c89e88bd6a74f4e510d83c6/src/services/RequestHandlers/List/IListHandlerAsyncT2.cs)*