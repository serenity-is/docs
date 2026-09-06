# ISaveRequestProcessorAsync.ProcessAsync method

Processes the [`ISaveRequest`](../ISaveRequest.md) asynchronously and returns a [`SaveResponse`](../SaveResponse.md).

```csharp
public Task<SaveResponse> ProcessAsync(IUnitOfWork uow, ISaveRequest request, SaveRequestType type, 
    CancellationToken cancellationToken = default)
```

| parameter | description |
| --- | --- |
| uow | Unit of work |
| request | Save request |
| type | Save request type, Create or Update |
| cancellationToken | Cancellation token |

## See Also

* class [SaveResponse](../SaveResponse.md)
* interface [IUnitOfWork](../../Serenity.Data/IUnitOfWork.md)
* interface [ISaveRequest](../ISaveRequest.md)
* enum [SaveRequestType](../SaveRequestType.md)
* interface [ISaveRequestProcessorAsync](../ISaveRequestProcessorAsync.md)