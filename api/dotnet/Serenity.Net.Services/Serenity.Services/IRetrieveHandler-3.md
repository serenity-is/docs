# IRetrieveHandler&lt;TRow,TRetrieveRequest,TRetrieveResponse&gt; interface
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

```csharp
public interface IRetrieveHandler<TRow, TRetrieveRequest, TRetrieveResponse> : 
    IRequestHandler<TRow, TRetrieveRequest, TRetrieveResponse>
    where TRow : class, IRow, new()
    where TRetrieveRequest : RetrieveRequest
    where TRetrieveResponse : RetrieveResponse<TRow>, new()
```

## Members

| name | description |
| --- | --- |
| [Retrieve](IRetrieveHandler-3/Retrieve.md)(…) |  |

## See Also

* interface [IRequestHandler&lt;TRow,TRequest,TResponse&gt;](IRequestHandler-3.md)
* class [TRow](../Serenity.Net.Services/IRetrieveHandler-3.TRow.md)
* class [TRetrieveRequest](../Serenity.Net.Services/IRetrieveHandler-3.TRetrieveRequest.md)
* class [TRetrieveResponse](../Serenity.Net.Services/IRetrieveHandler-3.TRetrieveResponse.md)
* interface [IRow](../Serenity.Net.Entity/../Serenity.Data/IRow.md)
* class [RetrieveRequest](RetrieveRequest.md)
* class [RetrieveResponse&lt;T&gt;](RetrieveResponse-1.md)
* **Source:** *[IRetrieveHandler.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Services/RequestHandlers/Retrieve/IRetrieveHandler.cs)*