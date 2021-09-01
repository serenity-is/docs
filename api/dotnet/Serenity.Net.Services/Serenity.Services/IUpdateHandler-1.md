# IUpdateHandler&lt;TRow&gt; interface
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

```csharp
public interface IUpdateHandler<TRow> : IUpdateHandler<TRow, SaveRequest<TRow>, SaveResponse>
    where TRow : class, IRow, IIdRow, new()
```

## See Also

* interface [IUpdateHandler&lt;TRow,TSaveRequest,TSaveResponse&gt;](IUpdateHandler-3.md)
* class [TRow](../Serenity.Net.Services/IUpdateHandler-1.TRow.md)
* class [SaveRequest&lt;TEntity&gt;](SaveRequest-1.md)
* class [SaveResponse](SaveResponse.md)
* interface [IRow](../Serenity.Net.Entity/../Serenity.Data/IRow.md)
* interface [IIdRow](../Serenity.Net.Entity/../Serenity.Data/IIdRow.md)
* **Source:** *[IUpdateHandler.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Services/RequestHandlers/Save/IUpdateHandler.cs)*