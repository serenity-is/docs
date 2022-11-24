# ISaveHandler&lt;TRow&gt; interface
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Interface for save request handlers

```csharp
public interface ISaveHandler<TRow> : ICreateHandler<TRow>, 
    ISaveHandler<TRow, SaveRequest<TRow>, SaveResponse>, IUpdateHandler<TRow>
    where TRow : class, IRow, IIdRow, new()
```

| parameter | description |
| --- | --- |
| TRow | Row type |

## See Also

* interface [ICreateHandler&lt;TRow&gt;](ICreateHandler-1.md)
* class [TRow](../Serenity.Net.Services/ISaveHandler-1.TRow.md)
* interface [ISaveHandler&lt;TRow,TSaveRequest,TSaveResponse&gt;](ISaveHandler-3.md)
* class [SaveRequest&lt;TEntity&gt;](SaveRequest-1.md)
* class [SaveResponse](SaveResponse.md)
* interface [IUpdateHandler&lt;TRow&gt;](IUpdateHandler-1.md)
* interface [IRow](../Serenity.Net.Entity/../Serenity.Data/IRow.md)
* interface [IIdRow](../Serenity.Net.Entity/../Serenity.Data/IIdRow.md)
* **Source:** *[ISaveHandlerT.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Services/RequestHandlers/Save/ISaveHandlerT.cs)*