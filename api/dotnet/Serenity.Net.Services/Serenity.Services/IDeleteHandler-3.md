# IDeleteHandler&lt;TRow,TDeleteRequest,TDeleteResponse&gt; interface
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

```csharp
public interface IDeleteHandler<TRow, TDeleteRequest, TDeleteResponse> : 
    IRequestHandler<TRow, TDeleteRequest, TDeleteResponse>
    where TRow : class, IRow, new()
    where TDeleteRequest : DeleteRequest
    where TDeleteResponse : DeleteResponse, new()
```

## Members

| name | description |
| --- | --- |
| [Delete](IDeleteHandler-3/Delete.md)(…) |  |

## See Also

* interface [IRequestHandler&lt;TRow,TRequest,TResponse&gt;](IRequestHandler-3.md)
* class [TRow](../Serenity.Net.Services/IDeleteHandler-3.TRow.md)
* class [TDeleteRequest](../Serenity.Net.Services/IDeleteHandler-3.TDeleteRequest.md)
* class [TDeleteResponse](../Serenity.Net.Services/IDeleteHandler-3.TDeleteResponse.md)
* interface [IRow](../Serenity.Net.Entity/../Serenity.Data/IRow.md)
* class [DeleteRequest](DeleteRequest.md)
* class [DeleteResponse](DeleteResponse.md)
* **Source:** *[IDeleteHandler.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Services/RequestHandlers/Delete/IDeleteHandler.cs)*