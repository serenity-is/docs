# SaveRequestHandler&lt;TRow,TSaveRequest,TSaveResponse&gt; class
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Generic base class for save request handlers

```csharp
public class SaveRequestHandler<TRow, TSaveRequest, TSaveResponse> : 
    SaveRequestHandlerBase<TRow, TSaveRequest, TSaveResponse>, 
    ISaveHandler<TRow, TSaveRequest, TSaveResponse>, ISaveRequestProcessor
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
| [SaveRequestHandler](SaveRequestHandler-3/SaveRequestHandler.md)(…) | Initializes a new instance of the class. |
| [Create](SaveRequestHandler-3/Create.md)(…) |  |
| [Process](SaveRequestHandler-3/Process.md)(…) | Processes the save request. This is the entry point for the handler. |
| [Update](SaveRequestHandler-3/Update.md)(…) |  |

## Protected Members

| name | description |
| --- | --- |
| [behaviors](SaveRequestHandler-3/behaviors.md) | Lazy list of behaviors that is activated for this request. |
| virtual [AfterSave](SaveRequestHandler-3/AfterSave.md)() | Called after executing the insert/update statement |
| virtual [BeforeSave](SaveRequestHandler-3/BeforeSave.md)() | Called before executing the insert/update statement |
| virtual [ExecuteSave](SaveRequestHandler-3/ExecuteSave.md)() | Executes the actual SQL save operation |
| virtual [HandleDisplayOrder](SaveRequestHandler-3/HandleDisplayOrder.md)(…) | Handles display order field calculation before and after save |
| virtual [InvokeSaveAction](SaveRequestHandler-3/InvokeSaveAction.md)(…) | Invokes the passed save action method |
| virtual [LoadOldEntity](SaveRequestHandler-3/LoadOldEntity.md)() | Loads the old entity for an update operation |
| virtual [OnReturn](SaveRequestHandler-3/OnReturn.md)() | Called just before the response is returned |
| virtual [PerformAuditing](SaveRequestHandler-3/PerformAuditing.md)() | Performs auditing |
| virtual [PrepareQuery](SaveRequestHandler-3/PrepareQuery.md)() | Prepares the query for selecting old record in an update operation. |
| virtual [SetInternalFields](SaveRequestHandler-3/SetInternalFields.md)() | Sets values for internal fields |
| virtual [ValidateRequest](SaveRequestHandler-3/ValidateRequest.md)() | Validates the request by checking insert / update permissions. |

## See Also

* class [SaveRequestHandlerBase&lt;TRow,TSaveRequest,TSaveResponse&gt;](./SaveRequestHandlerBase-3.md)
* interface [ISaveHandler&lt;TRow,TSaveRequest,TSaveResponse&gt;](./ISaveHandler-3.md)
* interface [ISaveRequestProcessor](./ISaveRequestProcessor.md)
* interface [IRow](../Serenity.Data/IRow.md)
* interface [IIdRow](../Serenity.Data/IIdRow.md)
* class [SaveRequest&lt;TEntity&gt;](./SaveRequest-1.md)
* class [SaveResponse](./SaveResponse.md)
* **Source:** *[SaveRequestHandler.cs](https://github.com/serenity-is/Serenity/blob/d867db7e483c51f5b1e62c31118c3b729fc6b78f/src/services/RequestHandlers/Save/SaveRequestHandler.cs)*