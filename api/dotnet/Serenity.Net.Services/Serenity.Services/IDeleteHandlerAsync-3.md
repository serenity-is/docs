# IDeleteHandlerAsync&lt;TRow,TDeleteRequest,TDeleteResponse&gt; interface
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Interface for async delete request handlers with custom delete request / response types.

```csharp
public interface IDeleteHandlerAsync<TRow, TDeleteRequest, TDeleteResponse> : 
    IRequestHandler<TRow, TDeleteRequest, TDeleteResponse>
    where TRow : class, IRow, new()
    where TDeleteRequest : DeleteRequest
    where TDeleteResponse : DeleteResponse, new()
```

| parameter | description |
| --- | --- |
| TRow | Row type |
| TDeleteRequest | Delete request type |
| TDeleteResponse | Delete response type |

## Members

| name | description |
| --- | --- |
| [DeleteAsync](IDeleteHandlerAsync-3/DeleteAsync.md)(…) | Processes a delete request asynchronously |

## See Also

* interface [IRequestHandler&lt;TRow,TRequest,TResponse&gt;](./IRequestHandler-3.md)
* interface [IRow](../Serenity.Data/IRow.md)
* class [DeleteRequest](./DeleteRequest.md)
* class [DeleteResponse](./DeleteResponse.md)
* **Source:** *[IDeleteHandlerAsync.cs](https://github.com/serenity-is/Serenity/blob/d867db7e483c51f5b1e62c31118c3b729fc6b78f/src/services/RequestHandlers/Delete/IDeleteHandlerAsync.cs)*