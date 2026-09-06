# IRetrieveHandler&lt;TRow,TRetrieveRequest,TRetrieveResponse&gt; interface
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Interface for retrieve request handlers with custom retrieve request / response types.

```csharp
public interface IRetrieveHandler<TRow, TRetrieveRequest, TRetrieveResponse> : 
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
| [Retrieve](IRetrieveHandler-3/Retrieve.md)(…) | Processes a Retrieve request. |

## See Also

* interface [IRequestHandler&lt;TRow,TRequest,TResponse&gt;](./IRequestHandler-3.md)
* interface [IRow](../Serenity.Data/IRow.md)
* class [RetrieveRequest](./RetrieveRequest.md)
* class [RetrieveResponse&lt;T&gt;](./RetrieveResponse-1.md)
* **Source:** *[IRetrieveHandler.cs](https://github.com/serenity-is/Serenity/blob/a5013fdf777dbbd87589205ddffcb67f18bea673/src/services/RequestHandlers/Retrieve/IRetrieveHandler.cs)*