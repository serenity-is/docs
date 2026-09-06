# IDeleteHandler&lt;TRow&gt; interface
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Interface for delete request handlers that use [`DeleteRequest`](./DeleteRequest.md) as request, and [`DeleteResponse`](./DeleteResponse.md) as response types.

```csharp
public interface IDeleteHandler<TRow> : IDeleteHandler<TRow, DeleteRequest, DeleteResponse>
    where TRow : class, IRow, new()
```

| parameter | description |
| --- | --- |
| TRow | Row type |

## See Also

* interface [IDeleteHandler&lt;TRow,TDeleteRequest,TDeleteResponse&gt;](./IDeleteHandler-3.md)
* class [DeleteRequest](./DeleteRequest.md)
* class [DeleteResponse](./DeleteResponse.md)
* interface [IRow](../Serenity.Data/IRow.md)
* **Source:** *[IDeleteHandler.cs](https://github.com/serenity-is/Serenity/blob/fa206546471018db1a28b90b807e2a73904efdfa/src/services/RequestHandlers/Delete/IDeleteHandler.cs)*