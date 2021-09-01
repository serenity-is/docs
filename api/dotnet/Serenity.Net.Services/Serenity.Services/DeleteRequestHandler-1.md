# DeleteRequestHandler&lt;TRow&gt; class
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

```csharp
public class DeleteRequestHandler<TRow> : 
    DeleteRequestHandler<TRow, DeleteRequest, DeleteResponse>, IDeleteHandler<TRow>
    where TRow : class, IRow, IIdRow, new()
```

## Public Members

| name | description |
| --- | --- |
| [DeleteRequestHandler](DeleteRequestHandler-1/DeleteRequestHandler.md)(…) |  |

## See Also

* class [DeleteRequestHandler&lt;TRow,TDeleteRequest,TDeleteResponse&gt;](DeleteRequestHandler-3.md)
* class [TRow](../Serenity.Net.Services/DeleteRequestHandler-1.TRow.md)
* class [DeleteRequest](DeleteRequest.md)
* class [DeleteResponse](DeleteResponse.md)
* interface [IDeleteHandler&lt;TRow&gt;](IDeleteHandler-1.md)
* interface [IRow](../Serenity.Net.Entity/../Serenity.Data/IRow.md)
* interface [IIdRow](../Serenity.Net.Entity/../Serenity.Data/IIdRow.md)
* **Source:** *[DeleteRequestHandlerT.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Services/RequestHandlers/Delete/DeleteRequestHandlerT.cs)*