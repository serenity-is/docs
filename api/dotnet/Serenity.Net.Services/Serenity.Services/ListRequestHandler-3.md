# ListRequestHandler&lt;TRow,TListRequest,TListResponse&gt; class
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Generic base class for list request handlers

```csharp
public class ListRequestHandler<TRow, TListRequest, TListResponse> : 
    ListRequestHandlerBase<TRow, TListRequest, TListResponse>, 
    IListHandler<TRow, TListRequest, TListResponse>, IListRequestProcessor
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
| [ListRequestHandler](ListRequestHandler-3/ListRequestHandler.md)(…) | Initializes a new instance of the class. |
| [List](ListRequestHandler-3/List.md)(…) |  |
| [Process](ListRequestHandler-3/Process.md)(…) | Processes the list request. This is the entry point for the handler. |

## Protected Members

| name | description |
| --- | --- |
| [behaviors](ListRequestHandler-3/behaviors.md) | Lazy list of behaviors that is activated for this request. |
| virtual [ApplyFilters](ListRequestHandler-3/ApplyFilters.md)(…) | Applies all the filters including Request.EqualityFilter, Request.Criteria and Request.IncludeDeleted to the query. |
| virtual [ExecuteQuery](ListRequestHandler-3/ExecuteQuery.md)() | Executes the query sets values / entities and total count. |
| override [MapFieldExpression](ListRequestHandler-3/MapFieldExpression.md)(…) |  |
| virtual [OnAfterExecuteQuery](ListRequestHandler-3/OnAfterExecuteQuery.md)() | Called after executing the list query |
| virtual [OnBeforeExecuteQuery](ListRequestHandler-3/OnBeforeExecuteQuery.md)() | Called before executing the list query |
| virtual [OnReturn](ListRequestHandler-3/OnReturn.md)() | Called just before returning the response |
| virtual [PrepareQuery](ListRequestHandler-3/PrepareQuery.md)(…) | Prepares query by selecting fields. |
| virtual [ValidateRequest](ListRequestHandler-3/ValidateRequest.md)() | Validates the request by checking permissions. |

## See Also

* class [ListRequestHandlerBase&lt;TRow,TListRequest,TListResponse&gt;](./ListRequestHandlerBase-3.md)
* interface [IListHandler&lt;TRow,TListRequest,TListResponse&gt;](./IListHandler-3.md)
* interface [IListRequestProcessor](./IListRequestProcessor.md)
* interface [IRow](../Serenity.Data/IRow.md)
* class [ListRequest](./ListRequest.md)
* class [ListResponse&lt;T&gt;](./ListResponse-1.md)
* **Source:** *[ListRequestHandler.cs](https://github.com/serenity-is/Serenity/blob/62e26a99abba7fd00c7409a1334581e3c5ccd1f4/src/services/RequestHandlers/List/ListRequestHandler.cs)*