# IRequestHandler&lt;TRow,TRequest,TResponse&gt; interface
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Marker interface for request handlers that operate on a specific entity type, request type and a response type.

```csharp
public interface IRequestHandler<TRow, TRequest, TResponse> : IRequestHandler<TRow>, 
    IRequestType<TRequest>, IResponseType<TResponse>
```

| parameter | description |
| --- | --- |
| TRow | The entity type |
| TRequest | Request type |
| TResponse | Response type |

## See Also

* interface [IRequestHandler&lt;TRow&gt;](IRequestHandler-1.md)
* class [TRow](../Serenity.Net.Services/IRequestHandler-3.TRow.md)
* interface [IRequestType&lt;TRequestType&gt;](IRequestType-1.md)
* class [TRequest](../Serenity.Net.Services/IRequestHandler-3.TRequest.md)
* interface [IResponseType&lt;TResponseType&gt;](IResponseType-1.md)
* class [TResponse](../Serenity.Net.Services/IRequestHandler-3.TResponse.md)
* **Source:** *[IRequestHandler.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Services/RequestHandlers/Handler/IRequestHandler.cs)*