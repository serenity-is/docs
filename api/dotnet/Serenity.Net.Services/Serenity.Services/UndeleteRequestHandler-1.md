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
| context | The request context |

## Public Members

| name | description |
| --- | --- |
| [UndeleteRequestHandler](UndeleteRequestHandler-1/UndeleteRequestHandler.md)(…) | Base generic class for undelete request handlers that use [`UndeleteRequest`](UndeleteRequest.md) as the request type, and [`UndeleteResponse`](UndeleteResponse.md) as the response type. |

## Remarks

Initializes a new instance of the class.

## See Also

* class [UndeleteRequestHandler&lt;TRow,TUndeleteRequest,TUndeleteResponse&gt;](UndeleteRequestHandler-3.md)
* class [TRow](../Serenity.Net.Services/UndeleteRequestHandler-1.TRow.md)
* class [UndeleteRequest](UndeleteRequest.md)
* class [UndeleteResponse](UndeleteResponse.md)
* interface [IUndeleteHandler&lt;TRow&gt;](IUndeleteHandler-1.md)
* interface [IRow](../Serenity.Data/IRow.md)
* interface [IIdRow](../Serenity.Data/IIdRow.md)
* **Source:** *[UndeleteRequestHandlerT.cs](https://github.com/serenity-is/Serenity/blob/a5013fdf777dbbd87589205ddffcb67f18bea673/src/services/RequestHandlers/Undelete/UndeleteRequestHandlerT.cs)*