# DeleteRequestHandler&lt;TRow&gt; class
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Base generic class for delete request handlers that use [`DeleteRequest`](DeleteRequest.md) as the request type, and [`DeleteResponse`](DeleteResponse.md) as the response type.

```csharp
public class DeleteRequestHandler<TRow> : 
    DeleteRequestHandler<TRow, DeleteRequest, DeleteResponse>, IDeleteHandler<TRow>
    where TRow : class, IRow, IIdRow, new()
```

| parameter | description |
| --- | --- |
| TRow | The entity type |
| context | The request context |

## Public Members

| name | description |
| --- | --- |
| [DeleteRequestHandler](DeleteRequestHandler-1/DeleteRequestHandler.md)(…) | Base generic class for delete request handlers that use [`DeleteRequest`](DeleteRequest.md) as the request type, and [`DeleteResponse`](DeleteResponse.md) as the response type. |

## Remarks

Creates an instance of the class

## See Also

* class [DeleteRequestHandler&lt;TRow,TDeleteRequest,TDeleteResponse&gt;](DeleteRequestHandler-3.md)
* class [TRow](../Serenity.Net.Services/DeleteRequestHandler-1.TRow.md)
* class [DeleteRequest](DeleteRequest.md)
* class [DeleteResponse](DeleteResponse.md)
* interface [IDeleteHandler&lt;TRow&gt;](IDeleteHandler-1.md)
* interface [IRow](../Serenity.Data/IRow.md)
* interface [IIdRow](../Serenity.Data/IIdRow.md)
* **Source:** *[DeleteRequestHandlerT.cs](https://github.com/serenity-is/Serenity/blob/master/src/Services/RequestHandlers/Delete/DeleteRequestHandlerT.cs)*