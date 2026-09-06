# SaveRequestHandlerAsync&lt;TRow,TSaveRequest,TSaveResponse&gt; class
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Generic base class for asynchronous save request handlers

```csharp
public class SaveRequestHandlerAsync<TRow, TSaveRequest, TSaveResponse> : 
    SaveRequestHandlerBase<TRow, TSaveRequest, TSaveResponse>, 
    ISaveHandlerAsync<TRow, TSaveRequest, TSaveResponse>, ISaveRequestProcessorAsync
    where TRow : class, IRow, IIdRow, new()
    where TSaveRequest : SaveRequest<TRow>, new()
    where TSaveResponse : SaveResponse, new()
```

| parameter | description |
| --- | --- |
| TRow | Entity type |
| TSaveRequest | Save request type |
| TSaveResponse | Save response type |

## Public Members

| name | description |
| --- | --- |
| [SaveRequestHandlerAsync](SaveRequestHandlerAsync-3/SaveRequestHandlerAsync.md)(…) | Initializes a new instance of the class. |
| [CreateAsync](SaveRequestHandlerAsync-3/CreateAsync.md)(…) |  |
| [ProcessAsync](SaveRequestHandlerAsync-3/ProcessAsync.md)(…) | Processes the save request asynchronously. This is the entry point for the handler. |
| [UpdateAsync](SaveRequestHandlerAsync-3/UpdateAsync.md)(…) |  |

## Protected Members

| name | description |
| --- | --- |
| [behaviors](SaveRequestHandlerAsync-3/behaviors.md) | Lazy list of behaviors that is activated for this request. |
| virtual [AfterSaveAsync](SaveRequestHandlerAsync-3/AfterSaveAsync.md)(…) | Called after executing the insert/update statement |
| virtual [BeforeSaveAsync](SaveRequestHandlerAsync-3/BeforeSaveAsync.md)(…) | Called before executing the insert/update statement |
| virtual [ExecuteSaveAsync](SaveRequestHandlerAsync-3/ExecuteSaveAsync.md)(…) | Executes the actual SQL save operation |
| virtual [HandleDisplayOrderAsync](SaveRequestHandlerAsync-3/HandleDisplayOrderAsync.md)(…) | Handles display order field calculation before and after save |
| virtual [InvokeSaveActionAsync](SaveRequestHandlerAsync-3/InvokeSaveActionAsync.md)(…) | Invokes the passed save action method |
| virtual [LoadOldEntityAsync](SaveRequestHandlerAsync-3/LoadOldEntityAsync.md)(…) | Loads the old entity for an update operation |
| virtual [OnReturnAsync](SaveRequestHandlerAsync-3/OnReturnAsync.md)(…) | Called just before the response is returned |
| virtual [PerformAuditingAsync](SaveRequestHandlerAsync-3/PerformAuditingAsync.md)(…) | Performs auditing |
| virtual [PrepareQueryAsync](SaveRequestHandlerAsync-3/PrepareQueryAsync.md)(…) | Prepares the query for selecting old record in an update operation. |
| virtual [SetInternalFieldsAsync](SaveRequestHandlerAsync-3/SetInternalFieldsAsync.md)(…) | Sets values for internal fields |
| virtual [ValidateRequestAsync](SaveRequestHandlerAsync-3/ValidateRequestAsync.md)(…) | Validates the request by checking insert / update permissions. |

## See Also

* class [SaveRequestHandlerBase&lt;TRow,TSaveRequest,TSaveResponse&gt;](./SaveRequestHandlerBase-3.md)
* interface [ISaveHandlerAsync&lt;TRow,TSaveRequest,TSaveResponse&gt;](./ISaveHandlerAsync-3.md)
* interface [ISaveRequestProcessorAsync](./ISaveRequestProcessorAsync.md)
* interface [IRow](../Serenity.Data/IRow.md)
* interface [IIdRow](../Serenity.Data/IIdRow.md)
* class [SaveRequest&lt;TEntity&gt;](./SaveRequest-1.md)
* class [SaveResponse](./SaveResponse.md)
* **Source:** *[SaveRequestHandlerAsync.cs](https://github.com/serenity-is/Serenity/blob/d867db7e483c51f5b1e62c31118c3b729fc6b78f/src/services/RequestHandlers/Save/SaveRequestHandlerAsync.cs)*