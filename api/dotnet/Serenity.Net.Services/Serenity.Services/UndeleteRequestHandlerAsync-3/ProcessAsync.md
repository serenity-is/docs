# UndeleteRequestHandlerAsync&lt;TRow,TUndeleteRequest,TUndeleteResponse&gt;.ProcessAsync method
**namespace:** *[Serenity.Services](../../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Processes the undelete request asynchronously. This is the entry point for the handler.

```csharp
public Task<TUndeleteResponse> ProcessAsync(IUnitOfWork unitOfWork, TUndeleteRequest request, 
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
| ArgumentNullException | *unitOfWork* is `null`. |

## See Also

* class [TUndeleteResponse](../Serenity.Net.Services/../UndeleteRequestHandlerAsync-3.TUndeleteResponse.md)
* interface [IUnitOfWork](../../Serenity.Data/IUnitOfWork.md)
* class [TUndeleteRequest](../Serenity.Net.Services/../UndeleteRequestHandlerAsync-3.TUndeleteRequest.md)
* class [UndeleteRequestHandlerAsync&lt;TRow,TUndeleteRequest,TUndeleteResponse&gt;](../UndeleteRequestHandlerAsync-3.md)