# IRetrieveHandlerAsync&lt;TRow&gt; interface
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Interface for async retrieve request handlers that use [`RetrieveRequest`](RetrieveRequest.md) as request, and [`RetrieveResponse`](RetrieveResponse-1.md) as response types.

```csharp
public interface IRetrieveHandlerAsync<TRow> : 
    IRetrieveHandlerAsync<TRow, RetrieveRequest, RetrieveResponse<TRow>>
    where TRow : class, IRow, new()
```

| parameter | description |
| --- | --- |
| TRow | Row type |

## See Also

* interface [IRetrieveHandlerAsync&lt;TRow,TRetrieveRequest,TRetrieveResponse&gt;](IRetrieveHandlerAsync-3.md)
* class [TRow](../Serenity.Net.Services/IRetrieveHandlerAsync-1.TRow.md)
* class [RetrieveRequest](RetrieveRequest.md)
* class [RetrieveResponse&lt;T&gt;](RetrieveResponse-1.md)
* interface [IRow](../Serenity.Data/IRow.md)
* **Source:** *[IRetrieveHandlerAsync.cs](https://github.com/serenity-is/Serenity/blob/aa5433b74475d7a249a3550344ee8ccea8e5a8eb/src/services/RequestHandlers/Retrieve/IRetrieveHandlerAsync.cs)*