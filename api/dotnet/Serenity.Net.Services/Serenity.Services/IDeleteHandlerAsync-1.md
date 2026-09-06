# IDeleteHandlerAsync&lt;TRow&gt; interface
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Interface for async delete request handlers that use [`DeleteRequest`](./DeleteRequest.md) as request, and [`DeleteResponse`](./DeleteResponse.md) as response types.

```csharp
public interface IDeleteHandlerAsync<TRow> : 
    IDeleteHandlerAsync<TRow, DeleteRequest, DeleteResponse>
    where TRow : class, IRow, new()
```

| parameter | description |
| --- | --- |
| TRow | Row type |

## See Also

* interface [IDeleteHandlerAsync&lt;TRow,TDeleteRequest,TDeleteResponse&gt;](./IDeleteHandlerAsync-3.md)
* class [DeleteRequest](./DeleteRequest.md)
* class [DeleteResponse](./DeleteResponse.md)
* interface [IRow](../Serenity.Data/IRow.md)
* **Source:** *[IDeleteHandlerAsync.cs](https://github.com/serenity-is/Serenity/blob/d867db7e483c51f5b1e62c31118c3b729fc6b78f/src/services/RequestHandlers/Delete/IDeleteHandlerAsync.cs)*