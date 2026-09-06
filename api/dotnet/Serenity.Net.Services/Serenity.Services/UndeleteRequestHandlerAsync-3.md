# UndeleteRequestHandlerAsync&lt;TRow,TUndeleteRequest,TUndeleteResponse&gt; class
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Generic base class for asynchronous undelete request handlers

```csharp
public class UndeleteRequestHandlerAsync<TRow, TUndeleteRequest, TUndeleteResponse> : 
    UndeleteRequestHandlerBase<TRow, TUndeleteRequest, TUndeleteResponse>, 
    IUndeleteHandlerAsync<TRow, TUndeleteRequest, TUndeleteResponse>, IUndeleteRequestProcessorAsync
    where TRow : class, IRow, IIdRow, new()
    where TUndeleteRequest : UndeleteRequest
    where TUndeleteResponse : UndeleteResponse, new()
```

| parameter | description |
| --- | --- |
| TRow | Entity type |
| TUndeleteRequest | Undelete request type |
| TUndeleteResponse | Undelete response type |

## Public Members

| name | description |
| --- | --- |
| [UndeleteRequestHandlerAsync](UndeleteRequestHandlerAsync-3/UndeleteRequestHandlerAsync.md)(…) | Initializes a new instance of the class. |
| [ProcessAsync](UndeleteRequestHandlerAsync-3/ProcessAsync.md)(…) | Processes the undelete request asynchronously. This is the entry point for the handler. |
| [UndeleteAsync](UndeleteRequestHandlerAsync-3/UndeleteAsync.md)(…) |  |

## Protected Members

| name | description |
| --- | --- |
| [behaviors-](UndeleteRequestHandlerAsync-3/behaviors-.md) | Lazy list of behaviors that is activated for this request. |
| virtual [DoAuditAsync](UndeleteRequestHandlerAsync-3/DoAuditAsync.md)(…) | Performs auditing |
| virtual [ExecuteUndeleteAsync](UndeleteRequestHandlerAsync-3/ExecuteUndeleteAsync.md)(…) | Executes the actual SQL undelete/update operation |
| virtual [InvokeUndeleteActionAsync](UndeleteRequestHandlerAsync-3/InvokeUndeleteActionAsync.md)(…) | Invokes the passed undelete action method |
| virtual [LoadEntityAsync](UndeleteRequestHandlerAsync-3/LoadEntityAsync.md)(…) | Loads the entity that is going to be undeleted |
| virtual [OnAfterUndeleteAsync](UndeleteRequestHandlerAsync-3/OnAfterUndeleteAsync.md)(…) | Method that is executed after the actual SQL undelete operation |
| virtual [OnBeforeUndeleteAsync](UndeleteRequestHandlerAsync-3/OnBeforeUndeleteAsync.md)(…) | Method that is executed before the actual SQL undelete operation. |
| virtual [OnReturnAsync](UndeleteRequestHandlerAsync-3/OnReturnAsync.md)(…) | The method that is called just before the response is returned. |
| virtual [PrepareQueryAsync](UndeleteRequestHandlerAsync-3/PrepareQueryAsync.md)(…) | Prepares the query used to select the existing record |
| virtual [ValidateRequestAsync](UndeleteRequestHandlerAsync-3/ValidateRequestAsync.md)(…) | Validates the parameters of the undelete request. |

## See Also

* class [UndeleteRequestHandlerBase&lt;TRow,TUndeleteRequest,TUndeleteResponse&gt;](UndeleteRequestHandlerBase-3.md)
* class [TRow](../Serenity.Net.Services/UndeleteRequestHandlerAsync-3.TRow.md)
* class [TUndeleteRequest](../Serenity.Net.Services/UndeleteRequestHandlerAsync-3.TUndeleteRequest.md)
* class [TUndeleteResponse](../Serenity.Net.Services/UndeleteRequestHandlerAsync-3.TUndeleteResponse.md)
* interface [IUndeleteHandlerAsync&lt;TRow,TUndeleteRequest,TUndeleteResponse&gt;](IUndeleteHandlerAsync-3.md)
* interface [IUndeleteRequestProcessorAsync](IUndeleteRequestProcessorAsync.md)
* interface [IRow](../Serenity.Data/IRow.md)
* interface [IIdRow](../Serenity.Data/IIdRow.md)
* class [UndeleteRequest](UndeleteRequest.md)
* class [UndeleteResponse](UndeleteResponse.md)
* **Source:** *[UndeleteRequestHandlerAsync.cs](https://github.com/serenity-is/Serenity/blob/574b0f91eebdcc8cdd7f9af77f617c5cf3fc4aec/src/services/RequestHandlers/Undelete/UndeleteRequestHandlerAsync.cs)*