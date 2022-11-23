# IUndeleteHandler&lt;TRow,TUndeleteRequest,TUndeleteResponse&gt; interface
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Interface for undelete request handlers with custom undelete request / response types.

```csharp
public interface IUndeleteHandler<TRow, TUndeleteRequest, TUndeleteResponse> : 
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
| [Undelete](IUndeleteHandler-3/Undelete.md)(…) | Processes a undelete request |

## See Also

* interface [IRequestHandler&lt;TRow,TRequest,TResponse&gt;](IRequestHandler-3.md)
* class [TRow](../Serenity.Net.Services/IUndeleteHandler-3.TRow.md)
* class [TUndeleteRequest](../Serenity.Net.Services/IUndeleteHandler-3.TUndeleteRequest.md)
* class [TUndeleteResponse](../Serenity.Net.Services/IUndeleteHandler-3.TUndeleteResponse.md)
* interface [IRow](../Serenity.Net.Entity/../Serenity.Data/IRow.md)
* class [UndeleteRequest](UndeleteRequest.md)
* class [UndeleteResponse](UndeleteResponse.md)
* **Source:** *[IUndeleteHandler.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Services/RequestHandlers/Undelete/IUndeleteHandler.cs)*