# IListHandler&lt;TRow,TListRequest&gt; interface
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Interface for list request handlers with a custom list request type.

```csharp
public interface IListHandler<TRow, TListRequest> : 
    IListHandler<TRow, TListRequest, ListResponse<TRow>>
    where TRow : class, IRow, new()
    where TListRequest : ListRequest
```

| parameter | description |
| --- | --- |
| TRow | Row type |
| TListRequest | List request type |

## See Also

* interface [IListHandler&lt;TRow,TListRequest,TListResponse&gt;](./IListHandler-3.md)
* class [ListResponse&lt;T&gt;](./ListResponse-1.md)
* interface [IRow](../Serenity.Data/IRow.md)
* class [ListRequest](./ListRequest.md)
* **Source:** *[IListHandlerT2.cs](https://github.com/serenity-is/Serenity/blob/fa206546471018db1a28b90b807e2a73904efdfa/src/services/RequestHandlers/List/IListHandlerT2.cs)*