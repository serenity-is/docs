# IListHandlerAsync&lt;TRow,TListRequest,TListResponse&gt; interface
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Interface for async list request handlers with custom list request / response types.

```csharp
public interface IListHandlerAsync<TRow, TListRequest, TListResponse> : 
    IRequestHandler<TRow, TListRequest, TListResponse>
    where TRow : class, IRow, new()
    where TListRequest : ListRequest
    where TListResponse : ListResponse<TRow>, new()
```

| parameter | description |
| --- | --- |
| TRow | Row type |
| TListRequest | List request type |
| TListResponse | List response type |

## Members

| name | description |
| --- | --- |
| [ListAsync](IListHandlerAsync-3/ListAsync.md)(…) | Processes a List request asynchronously |

## See Also

* interface [IRequestHandler&lt;TRow,TRequest,TResponse&gt;](./IRequestHandler-3.md)
* interface [IRow](../Serenity.Data/IRow.md)
* class [ListRequest](./ListRequest.md)
* class [ListResponse&lt;T&gt;](./ListResponse-1.md)
* **Source:** *[IListHandlerAsync.cs](https://github.com/serenity-is/Serenity/blob/6b0ee5bf7cf3317b3c89e88bd6a74f4e510d83c6/src/services/RequestHandlers/List/IListHandlerAsync.cs)*