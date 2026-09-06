# SaveRequestHandlerAsync&lt;TRow,TSaveRequest,TSaveResponse&gt;.ProcessAsync method

Processes the save request asynchronously. This is the entry point for the handler.

```csharp
public Task<TSaveResponse> ProcessAsync(IUnitOfWork unitOfWork, TSaveRequest request, 
    SaveRequestType requestType = SaveRequestType.Auto, 
    CancellationToken cancellationToken = default)
```

| parameter | description |
| --- | --- |
| unitOfWork | Unit of work |
| request | Request |
| requestType | Type of request, Create, Update or Auto |
| cancellationToken | Cancellation token |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | *unitOfWork* or *request* is `null`. |

## See Also

* interface [IUnitOfWork](../../Serenity.Data/IUnitOfWork.md)
* enum [SaveRequestType](../SaveRequestType.md)
* class [SaveRequestHandlerAsync&lt;TRow,TSaveRequest,TSaveResponse&gt;](../SaveRequestHandlerAsync-3.md)