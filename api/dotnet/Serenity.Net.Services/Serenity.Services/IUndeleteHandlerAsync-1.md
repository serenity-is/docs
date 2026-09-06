# IUndeleteHandlerAsync&lt;TRow&gt; interface
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Interface for async undelete request handlers that use [`UndeleteRequest`](UndeleteRequest.md) as request, and [`UndeleteResponse`](UndeleteResponse.md) as response types.

```csharp
public interface IUndeleteHandlerAsync<TRow> : 
    IUndeleteHandlerAsync<TRow, UndeleteRequest, UndeleteResponse>
    where TRow : class, IRow, new()
```

| parameter | description |
| --- | --- |
| TRow | Row type |

## See Also

* interface [IUndeleteHandlerAsync&lt;TRow,TUndeleteRequest,TUndeleteResponse&gt;](IUndeleteHandlerAsync-3.md)
* class [TRow](../Serenity.Net.Services/IUndeleteHandlerAsync-1.TRow.md)
* class [UndeleteRequest](UndeleteRequest.md)
* class [UndeleteResponse](UndeleteResponse.md)
* interface [IRow](../Serenity.Data/IRow.md)
* **Source:** *[IUndeleteHandlerAsync.cs](https://github.com/serenity-is/Serenity/blob/574b0f91eebdcc8cdd7f9af77f617c5cf3fc4aec/src/services/RequestHandlers/Undelete/IUndeleteHandlerAsync.cs)*