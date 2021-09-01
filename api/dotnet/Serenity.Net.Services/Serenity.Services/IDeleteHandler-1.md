# IDeleteHandler&lt;TRow&gt; interface
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

```csharp
public interface IDeleteHandler<TRow> : IDeleteHandler<TRow, DeleteRequest, DeleteResponse>
    where TRow : class, IRow, new()
```

## See Also

* interface [IDeleteHandler&lt;TRow,TDeleteRequest,TDeleteResponse&gt;](IDeleteHandler-3.md)
* class [TRow](../Serenity.Net.Services/IDeleteHandler-1.TRow.md)
* class [DeleteRequest](DeleteRequest.md)
* class [DeleteResponse](DeleteResponse.md)
* interface [IRow](../Serenity.Net.Entity/../Serenity.Data/IRow.md)
* **Source:** *[IDeleteHandler.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Services/RequestHandlers/Delete/IDeleteHandler.cs)*