# DeleteRequestHandlerAsync&lt;TRow,TDeleteRequest,TDeleteResponse&gt;.ProcessAsync method
**namespace:** *[Serenity.Services](../../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Processes the delete request asynchronously. This is the entry point for the handler.

```csharp
public Task<TDeleteResponse> ProcessAsync(IUnitOfWork unitOfWork, TDeleteRequest request, 
    CancellationToken cancellationToken = default(CancellationToken))
```

| parameter | description |
| --- | --- |
| unitOfWork | Unit of work |
| request | Request |
| cancellationToken | Cancellation token |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | *unitOfWork* or *request* is `null`. |

## See Also

* class [TDeleteResponse](../Serenity.Net.Services/../DeleteRequestHandlerAsync-3.TDeleteResponse.md)
* interface [IUnitOfWork](../../Serenity.Data/IUnitOfWork.md)
* class [TDeleteRequest](../Serenity.Net.Services/../DeleteRequestHandlerAsync-3.TDeleteRequest.md)
* class [DeleteRequestHandlerAsync&lt;TRow,TDeleteRequest,TDeleteResponse&gt;](../DeleteRequestHandlerAsync-3.md)