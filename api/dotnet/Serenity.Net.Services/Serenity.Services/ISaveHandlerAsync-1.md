# ISaveHandlerAsync&lt;TRow&gt; interface
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Interface for async save request handlers that use [`SaveRequest`](./SaveRequest-1.md) as the request type, and [`SaveResponse`](./SaveResponse.md) as the response type.

```csharp
public interface ISaveHandlerAsync<TRow> : ICreateHandlerAsync<TRow>, 
    ISaveHandlerAsync<TRow, SaveRequest<TRow>, SaveResponse>, IUpdateHandlerAsync<TRow>
    where TRow : class, IRow, IIdRow, new()
```

| parameter | description |
| --- | --- |
| TRow | Row type |

## See Also

* interface [ICreateHandlerAsync&lt;TRow&gt;](./ICreateHandlerAsync-1.md)
* interface [ISaveHandlerAsync&lt;TRow,TSaveRequest,TSaveResponse&gt;](./ISaveHandlerAsync-3.md)
* class [SaveRequest&lt;TEntity&gt;](./SaveRequest-1.md)
* class [SaveResponse](./SaveResponse.md)
* interface [IUpdateHandlerAsync&lt;TRow&gt;](./IUpdateHandlerAsync-1.md)
* interface [IRow](../Serenity.Data/IRow.md)
* interface [IIdRow](../Serenity.Data/IIdRow.md)
* **Source:** *[ISaveHandlerAsyncT.cs](https://github.com/serenity-is/Serenity/blob/04ac3ea58a41048bed911555c87969edcf6ea031/src/services/RequestHandlers/Save/ISaveHandlerAsyncT.cs)*