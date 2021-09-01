# IListHandler&lt;TRow&gt; interface
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

```csharp
public interface IListHandler<TRow> : IListHandler<TRow, ListRequest, ListResponse<TRow>>
    where TRow : class, IRow, new()
```

## See Also

* interface [IListHandler&lt;TRow,TListRequest,TListResponse&gt;](IListHandler-3.md)
* class [TRow](../Serenity.Net.Services/IListHandler-1.TRow.md)
* class [ListRequest](ListRequest.md)
* class [ListResponse&lt;T&gt;](ListResponse-1.md)
* interface [IRow](../Serenity.Net.Entity/../Serenity.Data/IRow.md)
* **Source:** *[IListHandler.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Services/RequestHandlers/List/IListHandler.cs)*