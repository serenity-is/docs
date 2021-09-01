# RetrieveRequestHandler&lt;TRow&gt; class
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

```csharp
public class RetrieveRequestHandler<TRow> : 
    RetrieveRequestHandler<TRow, RetrieveRequest, RetrieveResponse<TRow>>, IRetrieveHandler<TRow>
    where TRow : class, IRow, new()
```

## Public Members

| name | description |
| --- | --- |
| [RetrieveRequestHandler](RetrieveRequestHandler-1/RetrieveRequestHandler.md)(…) |  |

## See Also

* class [RetrieveRequestHandler&lt;TRow,TRetrieveRequest,TRetrieveResponse&gt;](RetrieveRequestHandler-3.md)
* class [TRow](../Serenity.Net.Services/RetrieveRequestHandler-1.TRow.md)
* class [RetrieveRequest](RetrieveRequest.md)
* class [RetrieveResponse&lt;T&gt;](RetrieveResponse-1.md)
* interface [IRetrieveHandler&lt;TRow&gt;](IRetrieveHandler-1.md)
* interface [IRow](../Serenity.Net.Entity/../Serenity.Data/IRow.md)
* **Source:** *[RetrieveRequestHandlerT.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Services/RequestHandlers/Retrieve/RetrieveRequestHandlerT.cs)*