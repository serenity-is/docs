# DeleteRequestHandlerAsync&lt;TRow&gt; class
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Base generic class for async delete request handlers that use [`DeleteRequest`](./DeleteRequest.md) as the request type, and [`DeleteResponse`](./DeleteResponse.md) as the response type.

```csharp
public class DeleteRequestHandlerAsync<TRow> : 
    DeleteRequestHandlerAsync<TRow, DeleteRequest, DeleteResponse>, IDeleteHandlerAsync<TRow>
    where TRow : class, IRow, IIdRow, new()
```

| parameter | description |
| --- | --- |
| TRow | The entity type |
| context | The request context |

## Public Members

| name | description |
| --- | --- |
| [DeleteRequestHandlerAsync](DeleteRequestHandlerAsync-1/DeleteRequestHandlerAsync.md)(…) | Base generic class for async delete request handlers that use [`DeleteRequest`](./DeleteRequest.md) as the request type, and [`DeleteResponse`](./DeleteResponse.md) as the response type. |

## Remarks

Initializes a new instance of the class.

## See Also

* class [DeleteRequestHandlerAsync&lt;TRow,TDeleteRequest,TDeleteResponse&gt;](./DeleteRequestHandlerAsync-3.md)
* class [DeleteRequest](./DeleteRequest.md)
* class [DeleteResponse](./DeleteResponse.md)
* interface [IDeleteHandlerAsync&lt;TRow&gt;](./IDeleteHandlerAsync-1.md)
* interface [IRow](../Serenity.Data/IRow.md)
* interface [IIdRow](../Serenity.Data/IIdRow.md)
* **Source:** *[DeleteRequestHandlerAsyncT.cs](https://github.com/serenity-is/Serenity/blob/d867db7e483c51f5b1e62c31118c3b729fc6b78f/src/services/RequestHandlers/Delete/DeleteRequestHandlerAsyncT.cs)*