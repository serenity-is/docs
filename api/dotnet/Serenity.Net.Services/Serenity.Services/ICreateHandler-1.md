# ICreateHandler&lt;TRow&gt; interface
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

```csharp
public interface ICreateHandler<TRow> : ICreateHandler<TRow, SaveRequest<TRow>, SaveResponse>
    where TRow : class, IRow, IIdRow, new()
```

## See Also

* interface [ICreateHandler&lt;TRow,TSaveRequest,TSaveResponse&gt;](ICreateHandler-3.md)
* class [TRow](../Serenity.Net.Services/ICreateHandler-1.TRow.md)
* class [SaveRequest&lt;TEntity&gt;](SaveRequest-1.md)
* class [SaveResponse](SaveResponse.md)
* interface [IRow](../Serenity.Net.Entity/../Serenity.Data/IRow.md)
* interface [IIdRow](../Serenity.Net.Entity/../Serenity.Data/IIdRow.md)
* **Source:** *[ICreateHandler.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Services/RequestHandlers/Save/ICreateHandler.cs)*