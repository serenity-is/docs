# IDeleteHandlerAsync&lt;TRow,TDeleteRequest,TDeleteResponse&gt;.DeleteAsync method
**namespace:** *[Serenity.Services](../../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Processes a delete request asynchronously

```csharp
public Task<TDeleteResponse> DeleteAsync(IUnitOfWork uow, TDeleteRequest request, 
    CancellationToken cancellationToken = default(CancellationToken))
```

| parameter | description |
| --- | --- |
| uow | Unit of work |
| request | The delete request |
| cancellationToken | Cancellation token |

## See Also

* class [TDeleteResponse](../Serenity.Net.Services/../IDeleteHandlerAsync-3.TDeleteResponse.md)
* interface [IUnitOfWork](../../Serenity.Data/IUnitOfWork.md)
* class [TDeleteRequest](../Serenity.Net.Services/../IDeleteHandlerAsync-3.TDeleteRequest.md)
* interface [IDeleteHandlerAsync&lt;TRow,TDeleteRequest,TDeleteResponse&gt;](../IDeleteHandlerAsync-3.md)