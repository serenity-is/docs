# RetrieveRequestHandlerAsync&lt;TRow&gt; class
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Base generic class for async retrieve request handlers that use [`RetrieveRequest`](RetrieveRequest.md) as the request type, and [`RetrieveResponse`](RetrieveResponse-1.md) as the response type.

```csharp
public class RetrieveRequestHandlerAsync<TRow> : 
    RetrieveRequestHandlerAsync<TRow, RetrieveRequest, RetrieveResponse<TRow>>, 
    IRetrieveHandlerAsync<TRow>
    where TRow : class, IRow, new()
```

| parameter | description |
| --- | --- |
| TRow | The entity type |
| context | The request context |

## Public Members

| name | description |
| --- | --- |
| [RetrieveRequestHandlerAsync](RetrieveRequestHandlerAsync-1/RetrieveRequestHandlerAsync.md)(…) | Base generic class for async retrieve request handlers that use [`RetrieveRequest`](RetrieveRequest.md) as the request type, and [`RetrieveResponse`](RetrieveResponse-1.md) as the response type. |

## Remarks

Initializes a new instance of the class.

## See Also

* class [RetrieveRequestHandlerAsync&lt;TRow,TRetrieveRequest,TRetrieveResponse&gt;](RetrieveRequestHandlerAsync-3.md)
* class [TRow](../Serenity.Net.Services/RetrieveRequestHandlerAsync-1.TRow.md)
* class [RetrieveRequest](RetrieveRequest.md)
* class [RetrieveResponse&lt;T&gt;](RetrieveResponse-1.md)
* interface [IRetrieveHandlerAsync&lt;TRow&gt;](IRetrieveHandlerAsync-1.md)
* interface [IRow](../Serenity.Data/IRow.md)
* **Source:** *[RetrieveRequestHandlerAsyncT.cs](https://github.com/serenity-is/Serenity/blob/aa5433b74475d7a249a3550344ee8ccea8e5a8eb/src/services/RequestHandlers/Retrieve/RetrieveRequestHandlerAsyncT.cs)*