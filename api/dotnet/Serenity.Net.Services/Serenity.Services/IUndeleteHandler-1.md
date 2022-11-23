# IUndeleteHandler&lt;TRow&gt; interface
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Interface for undelete request handlers that use [`UndeleteRequest`](UndeleteRequest.md) as request, and [`UndeleteResponse`](UndeleteResponse.md) as response types.

```csharp
public interface IUndeleteHandler<TRow> : IUndeleteHandler<TRow, UndeleteRequest, UndeleteResponse>
    where TRow : class, IRow, new()
```

| parameter | description |
| --- | --- |
| TRow | Row type |

## See Also

* interface [IUndeleteHandler&lt;TRow,TUndeleteRequest,TUndeleteResponse&gt;](IUndeleteHandler-3.md)
* class [TRow](../Serenity.Net.Services/IUndeleteHandler-1.TRow.md)
* class [UndeleteRequest](UndeleteRequest.md)
* class [UndeleteResponse](UndeleteResponse.md)
* interface [IRow](../Serenity.Net.Entity/../Serenity.Data/IRow.md)
* **Source:** *[IUndeleteHandler.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Services/RequestHandlers/Undelete/IUndeleteHandler.cs)*