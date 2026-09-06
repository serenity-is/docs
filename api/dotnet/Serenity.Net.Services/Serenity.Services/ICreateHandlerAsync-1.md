# ICreateHandlerAsync&lt;TRow&gt; interface
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Interface for async create request handlers that use [`SaveRequest`](SaveRequest-1.md) as the request type, and [`SaveResponse`](SaveResponse.md) as the response type.

```csharp
public interface ICreateHandlerAsync<TRow> : 
    ICreateHandlerAsync<TRow, SaveRequest<TRow>, SaveResponse>
    where TRow : class, IRow, IIdRow, new()
```

| parameter | description |
| --- | --- |
| TRow | Row type |

## See Also

* interface [ICreateHandlerAsync&lt;TRow,TSaveRequest,TSaveResponse&gt;](ICreateHandlerAsync-3.md)
* class [TRow](../Serenity.Net.Services/ICreateHandlerAsync-1.TRow.md)
* class [SaveRequest&lt;TEntity&gt;](SaveRequest-1.md)
* class [SaveResponse](SaveResponse.md)
* interface [IRow](../Serenity.Data/IRow.md)
* interface [IIdRow](../Serenity.Data/IIdRow.md)
* **Source:** *[ICreateHandlerAsyncT.cs](https://github.com/serenity-is/Serenity/blob/04ac3ea58a41048bed911555c87969edcf6ea031/src/services/RequestHandlers/Save/ICreateHandlerAsyncT.cs)*