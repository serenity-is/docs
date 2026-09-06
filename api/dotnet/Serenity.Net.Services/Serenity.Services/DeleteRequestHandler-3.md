# DeleteRequestHandler&lt;TRow,TDeleteRequest,TDeleteResponse&gt; class
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Generic base class for delete request handlers

```csharp
public class DeleteRequestHandler<TRow, TDeleteRequest, TDeleteResponse> : 
    DeleteRequestHandlerBase<TRow, TDeleteRequest, TDeleteResponse>, 
    IDeleteHandler<TRow, TDeleteRequest, TDeleteResponse>, IDeleteRequestProcessor
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
| [DeleteRequestHandler](DeleteRequestHandler-3/DeleteRequestHandler.md)(…) | Initializes a new instance of the class. |
| [Delete](DeleteRequestHandler-3/Delete.md)(…) |  |
| [Process](DeleteRequestHandler-3/Process.md)(…) | Processes the delete request. This is the entry point for the handler. |

## Protected Members

| name | description |
| --- | --- |
| [behaviors](DeleteRequestHandler-3/behaviors.md) | Lazy list of behaviors that is activated for this request. |
| virtual [DoAudit](DeleteRequestHandler-3/DoAudit.md)() | Performs auditing |
| virtual [ExecuteDelete](DeleteRequestHandler-3/ExecuteDelete.md)() | Executes the actual SQL delete operation |
| virtual [InvokeDeleteAction](DeleteRequestHandler-3/InvokeDeleteAction.md)(…) | Invokes the passed delete action method |
| virtual [LoadEntity](DeleteRequestHandler-3/LoadEntity.md)() | Loads the entity that is going to be deleted |
| virtual [OnAfterDelete](DeleteRequestHandler-3/OnAfterDelete.md)() | Method that is executed after the actual SQL delete operation |
| virtual [OnBeforeDelete](DeleteRequestHandler-3/OnBeforeDelete.md)() | Method that is executed before the actual SQL delete operation. |
| virtual [OnReturn](DeleteRequestHandler-3/OnReturn.md)() | The method that is called just before the response is returned. |
| virtual [PrepareQuery](DeleteRequestHandler-3/PrepareQuery.md)(…) | Prepares the query used to select the existing record |
| virtual [ValidateRequest](DeleteRequestHandler-3/ValidateRequest.md)() | Validates the parameters of the delete request. |

## See Also

* class [DeleteRequestHandlerBase&lt;TRow,TDeleteRequest,TDeleteResponse&gt;](./DeleteRequestHandlerBase-3.md)
* interface [IDeleteHandler&lt;TRow,TDeleteRequest,TDeleteResponse&gt;](./IDeleteHandler-3.md)
* interface [IDeleteRequestProcessor](./IDeleteRequestProcessor.md)
* interface [IRow](../Serenity.Data/IRow.md)
* interface [IIdRow](../Serenity.Data/IIdRow.md)
* class [DeleteRequest](./DeleteRequest.md)
* class [DeleteResponse](./DeleteResponse.md)
* **Source:** *[DeleteRequestHandler.cs](https://github.com/serenity-is/Serenity/blob/d867db7e483c51f5b1e62c31118c3b729fc6b78f/src/services/RequestHandlers/Delete/DeleteRequestHandler.cs)*