# ICreateHandlerAsync&lt;TRow,TSaveRequest,TSaveResponse&gt; interface
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Abstraction for create request handlers with an async Create method.

```csharp
public interface ICreateHandlerAsync<TRow, TSaveRequest, TSaveResponse> : 
    IRequestHandler<TRow, TSaveRequest, TSaveResponse>
    where TRow : class, IRow, IIdRow, new()
    where TSaveRequest : SaveRequest<TRow>, new()
    where TSaveResponse : SaveResponse, new()
```

| parameter | description |
| --- | --- |
| TRow | Row type |
| TSaveRequest | Save request type |
| TSaveResponse | Save response type |

## Members

| name | description |
| --- | --- |
| [CreateAsync](ICreateHandlerAsync-3/CreateAsync.md)(…) | Processes a Create request asynchronously |

## See Also

* interface [IRequestHandler&lt;TRow,TRequest,TResponse&gt;](./IRequestHandler-3.md)
* interface [IRow](../Serenity.Data/IRow.md)
* interface [IIdRow](../Serenity.Data/IIdRow.md)
* class [SaveRequest&lt;TEntity&gt;](./SaveRequest-1.md)
* class [SaveResponse](./SaveResponse.md)
* **Source:** *[ICreateHandlerAsync.cs](https://github.com/serenity-is/Serenity/blob/04ac3ea58a41048bed911555c87969edcf6ea031/src/services/RequestHandlers/Save/ICreateHandlerAsync.cs)*