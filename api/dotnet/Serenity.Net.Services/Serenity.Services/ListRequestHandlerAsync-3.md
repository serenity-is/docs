# ListRequestHandlerAsync&lt;TRow,TListRequest,TListResponse&gt; class
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Generic base class for asynchronous list request handlers

```csharp
public class ListRequestHandlerAsync<TRow, TListRequest, TListResponse> : 
    ListRequestHandlerBase<TRow, TListRequest, TListResponse>, 
    IListHandlerAsync<TRow, TListRequest, TListResponse>, IListRequestProcessorAsync
    where TRow : class, IRow, new()
    where TListRequest : ListRequest
    where TListResponse : ListResponse<TRow>, new()
```

| parameter | description |
| --- | --- |
| TRow | Entity type |
| TListRequest | List request type |
| TListResponse | List response type |

## Public Members

| name | description |
| --- | --- |
| [ListRequestHandlerAsync](ListRequestHandlerAsync-3/ListRequestHandlerAsync.md)(…) | Initializes a new instance of the class. |
| [ListAsync](ListRequestHandlerAsync-3/ListAsync.md)(…) |  |
| [ProcessAsync](ListRequestHandlerAsync-3/ProcessAsync.md)(…) | Processes the list request asynchronously. This is the entry point for the handler. |

## Protected Members

| name | description |
| --- | --- |
| [behaviors](ListRequestHandlerAsync-3/behaviors.md) | Lazy list of behaviors that is activated for this request. |
| virtual [ApplyFiltersAsync](ListRequestHandlerAsync-3/ApplyFiltersAsync.md)(…) | Applies all the filters including Request.EqualityFilter, Request.Criteria and Request.IncludeDeleted to the query. |
| virtual [ExecuteQueryAsync](ListRequestHandlerAsync-3/ExecuteQueryAsync.md)(…) | Executes the query sets values / entities and total count. |
| override [MapFieldExpression](ListRequestHandlerAsync-3/MapFieldExpression.md)(…) |  |
| virtual [OnAfterExecuteQueryAsync](ListRequestHandlerAsync-3/OnAfterExecuteQueryAsync.md)(…) | Called after executing the list query |
| virtual [OnBeforeExecuteQueryAsync](ListRequestHandlerAsync-3/OnBeforeExecuteQueryAsync.md)(…) | Called before executing the list query |
| virtual [OnReturnAsync](ListRequestHandlerAsync-3/OnReturnAsync.md)(…) | Called just before returning the response |
| virtual [PrepareQueryAsync](ListRequestHandlerAsync-3/PrepareQueryAsync.md)(…) | Prepares query by selecting fields. |
| virtual [ValidateRequestAsync](ListRequestHandlerAsync-3/ValidateRequestAsync.md)(…) | Validates the request by checking permissions. |

## See Also

* class [ListRequestHandlerBase&lt;TRow,TListRequest,TListResponse&gt;](./ListRequestHandlerBase-3.md)
* interface [IListHandlerAsync&lt;TRow,TListRequest,TListResponse&gt;](./IListHandlerAsync-3.md)
* interface [IListRequestProcessorAsync](./IListRequestProcessorAsync.md)
* interface [IRow](../Serenity.Data/IRow.md)
* class [ListRequest](./ListRequest.md)
* class [ListResponse&lt;T&gt;](./ListResponse-1.md)
* **Source:** *[ListRequestHandlerAsync.cs](https://github.com/serenity-is/Serenity/blob/62e26a99abba7fd00c7409a1334581e3c5ccd1f4/src/services/RequestHandlers/List/ListRequestHandlerAsync.cs)*