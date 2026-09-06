# DeleteRequestHandlerAsync&lt;TRow,TDeleteRequest,TDeleteResponse&gt; class
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Generic base class for asynchronous delete request handlers

```csharp
public class DeleteRequestHandlerAsync<TRow, TDeleteRequest, TDeleteResponse> : 
    DeleteRequestHandlerBase<TRow, TDeleteRequest, TDeleteResponse>, 
    IDeleteHandlerAsync<TRow, TDeleteRequest, TDeleteResponse>, IDeleteRequestProcessorAsync
    where TRow : class, IRow, IIdRow, new()
    where TDeleteRequest : DeleteRequest
    where TDeleteResponse : DeleteResponse, new()
```

| parameter | description |
| --- | --- |
| TRow | Entity type |
| TDeleteRequest | Delete request type |
| TDeleteResponse | Delete response type |

## Public Members

| name | description |
| --- | --- |
| [DeleteRequestHandlerAsync](DeleteRequestHandlerAsync-3/DeleteRequestHandlerAsync.md)(…) | Initializes a new instance of the class. |
| [DeleteAsync](DeleteRequestHandlerAsync-3/DeleteAsync.md)(…) |  |
| [ProcessAsync](DeleteRequestHandlerAsync-3/ProcessAsync.md)(…) | Processes the delete request asynchronously. This is the entry point for the handler. |

## Protected Members

| name | description |
| --- | --- |
| [behaviors-](DeleteRequestHandlerAsync-3/behaviors-.md) | Lazy list of behaviors that is activated for this request. |
| virtual [DoAuditAsync](DeleteRequestHandlerAsync-3/DoAuditAsync.md)(…) | Performs auditing |
| virtual [ExecuteDeleteAsync](DeleteRequestHandlerAsync-3/ExecuteDeleteAsync.md)(…) | Executes the actual SQL delete operation |
| virtual [InvokeDeleteActionAsync](DeleteRequestHandlerAsync-3/InvokeDeleteActionAsync.md)(…) | Invokes the passed delete action method |
| virtual [LoadEntityAsync](DeleteRequestHandlerAsync-3/LoadEntityAsync.md)(…) | Loads the entity that is going to be deleted |
| virtual [OnAfterDeleteAsync](DeleteRequestHandlerAsync-3/OnAfterDeleteAsync.md)(…) | Method that is executed after the actual SQL delete operation |
| virtual [OnBeforeDeleteAsync](DeleteRequestHandlerAsync-3/OnBeforeDeleteAsync.md)(…) | Method that is executed before the actual SQL delete operation. |
| virtual [OnReturnAsync](DeleteRequestHandlerAsync-3/OnReturnAsync.md)(…) | The method that is called just before the response is returned. |
| virtual [PrepareQueryAsync](DeleteRequestHandlerAsync-3/PrepareQueryAsync.md)(…) | Prepares the query used to select the existing record |
| virtual [ValidateRequestAsync](DeleteRequestHandlerAsync-3/ValidateRequestAsync.md)(…) | Validates the parameters of the delete request. |

## See Also

* class [DeleteRequestHandlerBase&lt;TRow,TDeleteRequest,TDeleteResponse&gt;](DeleteRequestHandlerBase-3.md)
* class [TRow](../Serenity.Net.Services/DeleteRequestHandlerAsync-3.TRow.md)
* class [TDeleteRequest](../Serenity.Net.Services/DeleteRequestHandlerAsync-3.TDeleteRequest.md)
* class [TDeleteResponse](../Serenity.Net.Services/DeleteRequestHandlerAsync-3.TDeleteResponse.md)
* interface [IDeleteHandlerAsync&lt;TRow,TDeleteRequest,TDeleteResponse&gt;](IDeleteHandlerAsync-3.md)
* interface [IDeleteRequestProcessorAsync](IDeleteRequestProcessorAsync.md)
* interface [IRow](../Serenity.Data/IRow.md)
* interface [IIdRow](../Serenity.Data/IIdRow.md)
* class [DeleteRequest](DeleteRequest.md)
* class [DeleteResponse](DeleteResponse.md)
* **Source:** *[DeleteRequestHandlerAsync.cs](https://github.com/serenity-is/Serenity/blob/d867db7e483c51f5b1e62c31118c3b729fc6b78f/src/services/RequestHandlers/Delete/DeleteRequestHandlerAsync.cs)*