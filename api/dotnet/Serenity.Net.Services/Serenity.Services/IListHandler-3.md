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

* interface [IRequestHandler&lt;TRow,TRequest,TResponse&gt;](IRequestHandler-3.md)
* class [TRow](../Serenity.Net.Services/IListHandler-3.TRow.md)
* class [TListRequest](../Serenity.Net.Services/IListHandler-3.TListRequest.md)
* class [TListResponse](../Serenity.Net.Services/IListHandler-3.TListResponse.md)
* interface [IRow](../Serenity.Net.Entity/../Serenity.Data/IRow.md)
* class [ListRequest](ListRequest.md)
* class [ListResponse&lt;T&gt;](ListResponse-1.md)
* **Source:** *[IListHandler.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Services/RequestHandlers/List/IListHandler.cs)*