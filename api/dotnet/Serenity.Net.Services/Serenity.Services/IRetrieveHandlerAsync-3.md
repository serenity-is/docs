# IRetrieveHandlerAsync&lt;TRow,TRetrieveRequest,TRetrieveResponse&gt; interface
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Interface for async retrieve request handlers with custom retrieve request / response types.

```csharp
public interface IRetrieveHandlerAsync<TRow, TRetrieveRequest, TRetrieveResponse> : 
    IRequestHandler<TRow, TRetrieveRequest, TRetrieveResponse>
    where TRow : class, IRow, new()
    where TRetrieveRequest : RetrieveRequest
    where TRetrieveResponse : RetrieveResponse<TRow>, new()
```

| parameter | description |
| --- | --- |
| TRow | Row type |
| TRetrieveRequest | Retrieve request type |
| TRetrieveResponse | Retrieve response type |

## Members

| name | description |
| --- | --- |
| [RetrieveAsync](IRetrieveHandlerAsync-3/RetrieveAsync.md)(…) | Processes a Retrieve request asynchronously. |

## See Also

* interface [IRequestHandler&lt;TRow,TRequest,TResponse&gt;](IRequestHandler-3.md)
* class [TRow](../Serenity.Net.Services/IRetrieveHandlerAsync-3.TRow.md)
* class [TRetrieveRequest](../Serenity.Net.Services/IRetrieveHandlerAsync-3.TRetrieveRequest.md)
* class [TRetrieveResponse](../Serenity.Net.Services/IRetrieveHandlerAsync-3.TRetrieveResponse.md)
* interface [IRow](../Serenity.Data/IRow.md)
* class [RetrieveRequest](RetrieveRequest.md)
* class [RetrieveResponse&lt;T&gt;](RetrieveResponse-1.md)
* **Source:** *[IRetrieveHandlerAsync.cs](https://github.com/serenity-is/Serenity/blob/aa5433b74475d7a249a3550344ee8ccea8e5a8eb/src/services/RequestHandlers/Retrieve/IRetrieveHandlerAsync.cs)*