# UndeleteRequestHandler&lt;TRow&gt; class
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Base generic class for undelete request handlers that use [`UndeleteRequest`](UndeleteRequest.md) as the request type, and [`UndeleteResponse`](UndeleteResponse.md) as the response type.

```csharp
public class UndeleteRequestHandler<TRow> : 
    UndeleteRequestHandler<TRow, UndeleteRequest, UndeleteResponse>, IUndeleteHandler<TRow>
    where TRow : class, IRow, IIdRow, new()
```

| parameter | description |
| --- | --- |
| TRow | The entity type |

## Public Members

| name | description |
| --- | --- |
| [UndeleteRequestHandler](UndeleteRequestHandler-1/UndeleteRequestHandler.md)(…) | Creates an instance of the class |

## See Also

* class [UndeleteRequestHandler&lt;TRow,TUndeleteRequest,TUndeleteResponse&gt;](UndeleteRequestHandler-3.md)
* class [TRow](../Serenity.Net.Services/UndeleteRequestHandler-1.TRow.md)
* class [UndeleteRequest](UndeleteRequest.md)
* class [UndeleteResponse](UndeleteResponse.md)
* interface [IUndeleteHandler&lt;TRow&gt;](IUndeleteHandler-1.md)
* interface [IRow](../Serenity.Net.Entity/../Serenity.Data/IRow.md)
* interface [IIdRow](../Serenity.Net.Entity/../Serenity.Data/IIdRow.md)
* **Source:** *[UndeleteRequestHandlerT.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Services/RequestHandlers/Undelete/UndeleteRequestHandlerT.cs)*