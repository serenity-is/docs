# IUpdateHandlerAsync&lt;TRow,TSaveRequest,TSaveResponse&gt;.UpdateAsync method
**namespace:** *[Serenity.Services](../../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Processes an Update request asynchronously

```csharp
public Task<TSaveResponse> UpdateAsync(IUnitOfWork uow, TSaveRequest request, 
    CancellationToken cancellationToken = default(CancellationToken))
```

| parameter | description |
| --- | --- |
| uow | Unit of work |
| request | Save request |
| cancellationToken | Cancellation token |

## See Also

* class [TSaveResponse](../Serenity.Net.Services/../IUpdateHandlerAsync-3.TSaveResponse.md)
* interface [IUnitOfWork](../../Serenity.Data/IUnitOfWork.md)
* class [TSaveRequest](../Serenity.Net.Services/../IUpdateHandlerAsync-3.TSaveRequest.md)
* interface [IUpdateHandlerAsync&lt;TRow,TSaveRequest,TSaveResponse&gt;](../IUpdateHandlerAsync-3.md)