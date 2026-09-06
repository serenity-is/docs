# IListHandler&lt;TRow,TListRequest,TListResponse&gt; interface
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Interface for list request handlers with custom list request / response types.

```csharp
public interface IListHandler<TRow, TListRequest, TListResponse> : 
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
| [List](IListHandler-3/List.md)(…) | Processes a List request |

## See Also

* interface [IRequestHandler&lt;TRow,TRequest,TResponse&gt;](./IRequestHandler-3.md)
* interface [IRow](../Serenity.Data/IRow.md)
* class [ListRequest](./ListRequest.md)
* class [ListResponse&lt;T&gt;](./ListResponse-1.md)
* **Source:** *[IListHandler.cs](https://github.com/serenity-is/Serenity/blob/fa206546471018db1a28b90b807e2a73904efdfa/src/services/RequestHandlers/List/IListHandler.cs)*