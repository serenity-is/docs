# IListHandler&lt;TRow&gt; interface
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Interface for list request handlers

```csharp
public interface IListHandler<TRow> : IListHandler<TRow, ListRequest, ListResponse<TRow>>
    where TRow : class, IRow, new()
```

| parameter | description |
| --- | --- |
| TRow | Row type |

## See Also

* interface [IListHandler&lt;TRow,TListRequest,TListResponse&gt;](IListHandler-3.md)
* class [TRow](../Serenity.Net.Services/IListHandler-1.TRow.md)
* class [ListRequest](ListRequest.md)
* class [ListResponse&lt;T&gt;](ListResponse-1.md)
* interface [IRow](../Serenity.Data/IRow.md)
* **Source:** *[IListHandlerT.cs](https://github.com/serenity-is/Serenity/blob/fa206546471018db1a28b90b807e2a73904efdfa/src/services/RequestHandlers/List/IListHandlerT.cs)*