# IListHandlerAsync&lt;TRow&gt; interface
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Interface for async list request handlers that use [`ListRequest`](./ListRequest.md) as request, and [`ListResponse`](./ListResponse-1.md) as response types.

```csharp
public interface IListHandlerAsync<TRow> : IListHandlerAsync<TRow, ListRequest>
    where TRow : class, IRow, new()
```

| parameter | description |
| --- | --- |
| TRow | Row type |

## See Also

* interface [IListHandlerAsync&lt;TRow,TListRequest&gt;](./IListHandlerAsync-2.md)
* class [ListRequest](./ListRequest.md)
* interface [IRow](../Serenity.Data/IRow.md)
* **Source:** *[IListHandlerAsync.cs](https://github.com/serenity-is/Serenity/blob/6b0ee5bf7cf3317b3c89e88bd6a74f4e510d83c6/src/services/RequestHandlers/List/IListHandlerAsync.cs)*