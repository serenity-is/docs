# UndeleteRequestHandlerAsync&lt;TRow&gt; class
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Base generic class for async undelete request handlers that use [`UndeleteRequest`](UndeleteRequest.md) as the request type, and [`UndeleteResponse`](UndeleteResponse.md) as the response type.

```csharp
public class UndeleteRequestHandlerAsync<TRow> : 
    UndeleteRequestHandlerAsync<TRow, UndeleteRequest, UndeleteResponse>, 
    IUndeleteHandlerAsync<TRow>
    where TRow : class, IRow, IIdRow, new()
```

| parameter | description |
| --- | --- |
| TRow | The entity type |
| context | The request context |

## Public Members

| name | description |
| --- | --- |
| [UndeleteRequestHandlerAsync](UndeleteRequestHandlerAsync-1/UndeleteRequestHandlerAsync.md)(…) | Base generic class for async undelete request handlers that use [`UndeleteRequest`](UndeleteRequest.md) as the request type, and [`UndeleteResponse`](UndeleteResponse.md) as the response type. |

## Remarks

Initializes a new instance of the class.

## See Also

* class [UndeleteRequestHandlerAsync&lt;TRow,TUndeleteRequest,TUndeleteResponse&gt;](UndeleteRequestHandlerAsync-3.md)
* class [TRow](../Serenity.Net.Services/UndeleteRequestHandlerAsync-1.TRow.md)
* class [UndeleteRequest](UndeleteRequest.md)
* class [UndeleteResponse](UndeleteResponse.md)
* interface [IUndeleteHandlerAsync&lt;TRow&gt;](IUndeleteHandlerAsync-1.md)
* interface [IRow](../Serenity.Data/IRow.md)
* interface [IIdRow](../Serenity.Data/IIdRow.md)
* **Source:** *[UndeleteRequestHandlerAsyncT.cs](https://github.com/serenity-is/Serenity/blob/574b0f91eebdcc8cdd7f9af77f617c5cf3fc4aec/src/services/RequestHandlers/Undelete/UndeleteRequestHandlerAsyncT.cs)*