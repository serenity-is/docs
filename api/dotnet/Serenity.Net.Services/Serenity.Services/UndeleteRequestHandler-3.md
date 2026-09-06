# UndeleteRequestHandler&lt;TRow,TUndeleteRequest,TUndeleteResponse&gt; class
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Generic base class for undelete request handlers

```csharp
public class UndeleteRequestHandler<TRow, TUndeleteRequest, TUndeleteResponse> : 
    UndeleteRequestHandlerBase<TRow, TUndeleteRequest, TUndeleteResponse>, 
    IUndeleteHandler<TRow, TUndeleteRequest, TUndeleteResponse>, IUndeleteRequestProcessor
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
| [UndeleteRequestHandler](UndeleteRequestHandler-3/UndeleteRequestHandler.md)(…) | Initializes a new instance of the class. |
| [Process](UndeleteRequestHandler-3/Process.md)(…) | Processes the undelete request. This is the entry point for the handler. |
| [Undelete](UndeleteRequestHandler-3/Undelete.md)(…) |  |

## Protected Members

| name | description |
| --- | --- |
| [behaviors](UndeleteRequestHandler-3/behaviors.md) | Lazy list of behaviors that is activated for this request. |
| virtual [DoAudit](UndeleteRequestHandler-3/DoAudit.md)() | Performs auditing |
| virtual [ExecuteUndelete](UndeleteRequestHandler-3/ExecuteUndelete.md)() | Executes the actual SQL undelete/update operation |
| virtual [InvokeUndeleteAction](UndeleteRequestHandler-3/InvokeUndeleteAction.md)(…) | Invokes the passed undelete action method |
| virtual [LoadEntity](UndeleteRequestHandler-3/LoadEntity.md)() | Loads the entity that is going to be undeleted |
| virtual [OnAfterUndelete](UndeleteRequestHandler-3/OnAfterUndelete.md)() | Method that is executed after the actual SQL undelete operation |
| virtual [OnBeforeUndelete](UndeleteRequestHandler-3/OnBeforeUndelete.md)() | Method that is executed before the actual SQL undelete operation. |
| virtual [OnReturn](UndeleteRequestHandler-3/OnReturn.md)() | The method that is called just before the response is returned. |
| virtual [PrepareQuery](UndeleteRequestHandler-3/PrepareQuery.md)(…) | Prepares the query used to select the existing record |
| virtual [ValidateRequest](UndeleteRequestHandler-3/ValidateRequest.md)() | Validates the parameters of the undelete request. |

## See Also

* class [UndeleteRequestHandlerBase&lt;TRow,TUndeleteRequest,TUndeleteResponse&gt;](./UndeleteRequestHandlerBase-3.md)
* interface [IUndeleteHandler&lt;TRow,TUndeleteRequest,TUndeleteResponse&gt;](./IUndeleteHandler-3.md)
* interface [IUndeleteRequestProcessor](./IUndeleteRequestProcessor.md)
* interface [IRow](../Serenity.Data/IRow.md)
* interface [IIdRow](../Serenity.Data/IIdRow.md)
* class [UndeleteRequest](./UndeleteRequest.md)
* class [UndeleteResponse](./UndeleteResponse.md)
* **Source:** *[UndeleteRequestHandler.cs](https://github.com/serenity-is/Serenity/blob/574b0f91eebdcc8cdd7f9af77f617c5cf3fc4aec/src/services/RequestHandlers/Undelete/UndeleteRequestHandler.cs)*