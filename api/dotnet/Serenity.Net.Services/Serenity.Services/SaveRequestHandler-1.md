# SaveRequestHandler&lt;TRow&gt; class
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Base generic class for save request handlers that use [`SaveRequest`](SaveRequest-1.md) as the request type, and [`SaveResponse`](SaveResponse.md) as the response type.

```csharp
public class SaveRequestHandler<TRow> : SaveRequestHandler<TRow, SaveRequest<TRow>, SaveResponse>, 
    ISaveHandler<TRow>
    where TRow : class, IRow, IIdRow, new()
```

| parameter | description |
| --- | --- |
| TRow | The entity type |

## Public Members

| name | description |
| --- | --- |
| [SaveRequestHandler](SaveRequestHandler-1/SaveRequestHandler.md)(…) | Creates a new instance of the class |

## See Also

* class [SaveRequestHandler&lt;TRow,TSaveRequest,TSaveResponse&gt;](SaveRequestHandler-3.md)
* class [TRow](../Serenity.Net.Services/SaveRequestHandler-1.TRow.md)
* class [SaveRequest&lt;TEntity&gt;](SaveRequest-1.md)
* class [SaveResponse](SaveResponse.md)
* interface [ISaveHandler&lt;TRow&gt;](ISaveHandler-1.md)
* interface [IRow](../Serenity.Net.Entity/../Serenity.Data/IRow.md)
* interface [IIdRow](../Serenity.Net.Entity/../Serenity.Data/IIdRow.md)
* **Source:** *[SaveRequestHandlerT.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Services/RequestHandlers/Save/SaveRequestHandlerT.cs)*