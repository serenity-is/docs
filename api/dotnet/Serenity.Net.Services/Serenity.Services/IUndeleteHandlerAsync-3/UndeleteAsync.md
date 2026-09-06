# IUndeleteHandlerAsync&lt;TRow,TUndeleteRequest,TUndeleteResponse&gt;.UndeleteAsync method
**namespace:** *[Serenity.Services](../../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Processes an undelete request asynchronously

```csharp
public Task<TUndeleteResponse> UndeleteAsync(IUnitOfWork uow, TUndeleteRequest request, 
    CancellationToken cancellationToken = default(CancellationToken))
```

| parameter | description |
| --- | --- |
| uow | Unit of work |
| request | The undelete request |
| cancellationToken | Cancellation token |

## See Also

* class [TUndeleteResponse](../Serenity.Net.Services/../IUndeleteHandlerAsync-3.TUndeleteResponse.md)
* interface [IUnitOfWork](../../Serenity.Data/IUnitOfWork.md)
* class [TUndeleteRequest](../Serenity.Net.Services/../IUndeleteHandlerAsync-3.TUndeleteRequest.md)
* interface [IUndeleteHandlerAsync&lt;TRow,TUndeleteRequest,TUndeleteResponse&gt;](../IUndeleteHandlerAsync-3.md)