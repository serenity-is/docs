# SaveRequestHandlerAsync&lt;TRow&gt; class
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Base generic class for async save request handlers that use [`SaveRequest`](SaveRequest-1.md) as the request type, and [`SaveResponse`](SaveResponse.md) as the response type.

```csharp
public class SaveRequestHandlerAsync<TRow> : 
    SaveRequestHandlerAsync<TRow, SaveRequest<TRow>, SaveResponse>, ISaveHandlerAsync<TRow>
    where TRow : class, IRow, IIdRow, new()
```

| parameter | description |
| --- | --- |
| TRow | The entity type |
| context | Request context |

## Public Members

| name | description |
| --- | --- |
| [SaveRequestHandlerAsync](SaveRequestHandlerAsync-1/SaveRequestHandlerAsync.md)(…) | Base generic class for async save request handlers that use [`SaveRequest`](SaveRequest-1.md) as the request type, and [`SaveResponse`](SaveResponse.md) as the response type. |

## Remarks

Initializes a new instance of the class.

## See Also

* class [SaveRequestHandlerAsync&lt;TRow,TSaveRequest,TSaveResponse&gt;](SaveRequestHandlerAsync-3.md)
* class [TRow](../Serenity.Net.Services/SaveRequestHandlerAsync-1.TRow.md)
* class [SaveRequest&lt;TEntity&gt;](SaveRequest-1.md)
* class [SaveResponse](SaveResponse.md)
* interface [ISaveHandlerAsync&lt;TRow&gt;](ISaveHandlerAsync-1.md)
* interface [IRow](../Serenity.Data/IRow.md)
* interface [IIdRow](../Serenity.Data/IIdRow.md)
* **Source:** *[SaveRequestHandlerAsyncT.cs](https://github.com/serenity-is/Serenity/blob/04ac3ea58a41048bed911555c87969edcf6ea031/src/services/RequestHandlers/Save/SaveRequestHandlerAsyncT.cs)*