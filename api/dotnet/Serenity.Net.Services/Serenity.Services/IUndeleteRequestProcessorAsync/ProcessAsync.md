# IUndeleteRequestProcessorAsync.ProcessAsync method

Processes the [`UndeleteRequest`](../UndeleteRequest.md) asynchronously and returns a [`UndeleteResponse`](../UndeleteResponse.md)

```csharp
public Task<UndeleteResponse> ProcessAsync(IUnitOfWork uow, UndeleteRequest request, 
    CancellationToken cancellationToken = default)
```

| parameter | description |
| --- | --- |
| uow | Unit of work |
| request | Undelete request |
| cancellationToken | Cancellation token |

## See Also

* class [UndeleteResponse](../UndeleteResponse.md)
* interface [IUnitOfWork](../../Serenity.Data/IUnitOfWork.md)
* class [UndeleteRequest](../UndeleteRequest.md)
* interface [IUndeleteRequestProcessorAsync](../IUndeleteRequestProcessorAsync.md)