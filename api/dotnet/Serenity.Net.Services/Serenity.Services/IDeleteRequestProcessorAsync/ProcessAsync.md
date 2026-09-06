# IDeleteRequestProcessorAsync.ProcessAsync method

Processes the [`DeleteRequest`](../DeleteRequest.md) asynchronously and returns a [`DeleteResponse`](../DeleteResponse.md)

```csharp
public Task<DeleteResponse> ProcessAsync(IUnitOfWork uow, DeleteRequest request, 
    CancellationToken cancellationToken = default)
```

| parameter | description |
| --- | --- |
| uow | Unit of work |
| request | Delete request |
| cancellationToken | Cancellation token |

## See Also

* class [DeleteResponse](../DeleteResponse.md)
* interface [IUnitOfWork](../../Serenity.Data/IUnitOfWork.md)
* class [DeleteRequest](../DeleteRequest.md)
* interface [IDeleteRequestProcessorAsync](../IDeleteRequestProcessorAsync.md)