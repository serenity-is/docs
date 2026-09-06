# IUndeleteHandlerAsync&lt;TRow,TUndeleteRequest,TUndeleteResponse&gt; interface
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Interface for async undelete request handlers with custom undelete request / response types.

```csharp
public interface IUndeleteHandlerAsync<TRow, TUndeleteRequest, TUndeleteResponse> : 
    IRequestHandler<TRow, TUndeleteRequest, TUndeleteResponse>
    where TRow : class, IRow, new()
    where TUndeleteRequest : UndeleteRequest
    where TUndeleteResponse : UndeleteResponse, new()
```

| parameter | description |
| --- | --- |
| TRow | Row type |
| TUndeleteRequest | Undelete request type |
| TUndeleteResponse | Undelete response type |

## Members

| name | description |
| --- | --- |
| [UndeleteAsync](IUndeleteHandlerAsync-3/UndeleteAsync.md)(…) | Processes an undelete request asynchronously |

## See Also

* interface [IRequestHandler&lt;TRow,TRequest,TResponse&gt;](IRequestHandler-3.md)
* class [TRow](../Serenity.Net.Services/IUndeleteHandlerAsync-3.TRow.md)
* class [TUndeleteRequest](../Serenity.Net.Services/IUndeleteHandlerAsync-3.TUndeleteRequest.md)
* class [TUndeleteResponse](../Serenity.Net.Services/IUndeleteHandlerAsync-3.TUndeleteResponse.md)
* interface [IRow](../Serenity.Data/IRow.md)
* class [UndeleteRequest](UndeleteRequest.md)
* class [UndeleteResponse](UndeleteResponse.md)
* **Source:** *[IUndeleteHandlerAsync.cs](https://github.com/serenity-is/Serenity/blob/574b0f91eebdcc8cdd7f9af77f617c5cf3fc4aec/src/services/RequestHandlers/Undelete/IUndeleteHandlerAsync.cs)*