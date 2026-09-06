# RetrieveRequestHandlerAsync&lt;TRow,TRetrieveRequest,TRetrieveResponse&gt; class
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Generic base class for asynchronous retrieve request handlers

```csharp
public class RetrieveRequestHandlerAsync<TRow, TRetrieveRequest, TRetrieveResponse> : 
    RetrieveRequestHandlerBase<TRow, TRetrieveRequest, TRetrieveResponse>, 
    IRetrieveHandlerAsync<TRow, TRetrieveRequest, TRetrieveResponse>, IRetrieveRequestProcessorAsync
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
| [RetrieveRequestHandlerAsync](RetrieveRequestHandlerAsync-3/RetrieveRequestHandlerAsync.md)(…) | Initializes a new instance of the class. |
| [ProcessAsync](RetrieveRequestHandlerAsync-3/ProcessAsync.md)(…) | Processes the retrieve request asynchronously. This is the entry point for the handler. |
| [RetrieveAsync](RetrieveRequestHandlerAsync-3/RetrieveAsync.md)(…) |  |

## Protected Members

| name | description |
| --- | --- |
| [behaviors](RetrieveRequestHandlerAsync-3/behaviors.md) | Lazy list of behaviors that is activated for this request. |
| virtual [ExecuteQueryAsync](RetrieveRequestHandlerAsync-3/ExecuteQueryAsync.md)(…) | Executes the query and sets the response entity if found. |
| virtual [OnAfterExecuteQueryAsync](RetrieveRequestHandlerAsync-3/OnAfterExecuteQueryAsync.md)(…) | Called after executing the retrieve query |
| virtual [OnBeforeExecuteQueryAsync](RetrieveRequestHandlerAsync-3/OnBeforeExecuteQueryAsync.md)(…) | Called before executing the retrieve query |
| virtual [OnReturnAsync](RetrieveRequestHandlerAsync-3/OnReturnAsync.md)(…) | Called just before returning the response |
| virtual [PrepareQueryAsync](RetrieveRequestHandlerAsync-3/PrepareQueryAsync.md)(…) | Prepares query by selecting fields. |
| virtual [ValidateRequestAsync](RetrieveRequestHandlerAsync-3/ValidateRequestAsync.md)(…) | Validates the request by checking permissions. |

## See Also

* class [RetrieveRequestHandlerBase&lt;TRow,TRetrieveRequest,TRetrieveResponse&gt;](./RetrieveRequestHandlerBase-3.md)
* interface [IRetrieveHandlerAsync&lt;TRow,TRetrieveRequest,TRetrieveResponse&gt;](./IRetrieveHandlerAsync-3.md)
* interface [IRetrieveRequestProcessorAsync](./IRetrieveRequestProcessorAsync.md)
* interface [IRow](../Serenity.Data/IRow.md)
* class [RetrieveRequest](./RetrieveRequest.md)
* class [RetrieveResponse&lt;T&gt;](./RetrieveResponse-1.md)
* **Source:** *[RetrieveRequestHandlerAsync.cs](https://github.com/serenity-is/Serenity/blob/aa5433b74475d7a249a3550344ee8ccea8e5a8eb/src/services/RequestHandlers/Retrieve/RetrieveRequestHandlerAsync.cs)*