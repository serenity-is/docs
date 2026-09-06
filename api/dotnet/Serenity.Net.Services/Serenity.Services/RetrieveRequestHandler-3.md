# RetrieveRequestHandler&lt;TRow,TRetrieveRequest,TRetrieveResponse&gt; class
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Generic base class for retrieve request handlers

```csharp
public class RetrieveRequestHandler<TRow, TRetrieveRequest, TRetrieveResponse> : 
    RetrieveRequestHandlerBase<TRow, TRetrieveRequest, TRetrieveResponse>, 
    IRetrieveHandler<TRow, TRetrieveRequest, TRetrieveResponse>, IRetrieveRequestProcessor
    where TRow : class, IRow, new()
    where TRetrieveRequest : RetrieveRequest
    where TRetrieveResponse : RetrieveResponse<TRow>, new()
```

| parameter | description |
| --- | --- |
| TRow | Entity type |
| TRetrieveRequest | Retrieve request type |
| TRetrieveResponse | Retrieve response type |

## Public Members

| name | description |
| --- | --- |
| [RetrieveRequestHandler](RetrieveRequestHandler-3/RetrieveRequestHandler.md)(…) | Initializes a new instance of the class. |
| [Process](RetrieveRequestHandler-3/Process.md)(…) | Processes the retrieve request. This is the entry point for the handler. |
| [Retrieve](RetrieveRequestHandler-3/Retrieve.md)(…) |  |

## Protected Members

| name | description |
| --- | --- |
| [behaviors-](RetrieveRequestHandler-3/behaviors-.md) | Lazy list of behaviors that is activated for this request. |
| virtual [ExecuteQuery](RetrieveRequestHandler-3/ExecuteQuery.md)() | Executes the query and sets the response entity if found. |
| virtual [OnAfterExecuteQuery](RetrieveRequestHandler-3/OnAfterExecuteQuery.md)() | Called after executing the retrieve query |
| virtual [OnBeforeExecuteQuery](RetrieveRequestHandler-3/OnBeforeExecuteQuery.md)() | Called before executing the retrieve query |
| virtual [OnReturn](RetrieveRequestHandler-3/OnReturn.md)() | Called just before returning the response |
| virtual [PrepareQuery](RetrieveRequestHandler-3/PrepareQuery.md)(…) | Prepares query by selecting fields. |
| virtual [ValidateRequest](RetrieveRequestHandler-3/ValidateRequest.md)() | Validates the request by checking permissions. |

## See Also

* class [RetrieveRequestHandlerBase&lt;TRow,TRetrieveRequest,TRetrieveResponse&gt;](RetrieveRequestHandlerBase-3.md)
* class [TRow](../Serenity.Net.Services/RetrieveRequestHandler-3.TRow.md)
* class [TRetrieveRequest](../Serenity.Net.Services/RetrieveRequestHandler-3.TRetrieveRequest.md)
* class [TRetrieveResponse](../Serenity.Net.Services/RetrieveRequestHandler-3.TRetrieveResponse.md)
* interface [IRetrieveHandler&lt;TRow,TRetrieveRequest,TRetrieveResponse&gt;](IRetrieveHandler-3.md)
* interface [IRetrieveRequestProcessor](IRetrieveRequestProcessor.md)
* interface [IRow](../Serenity.Data/IRow.md)
* class [RetrieveRequest](RetrieveRequest.md)
* class [RetrieveResponse&lt;T&gt;](RetrieveResponse-1.md)
* **Source:** *[RetrieveRequestHandler.cs](https://github.com/serenity-is/Serenity/blob/aa5433b74475d7a249a3550344ee8ccea8e5a8eb/src/services/RequestHandlers/Retrieve/RetrieveRequestHandler.cs)*