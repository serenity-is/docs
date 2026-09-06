# IUpdateHandlerAsync&lt;TRow,TSaveRequest,TSaveResponse&gt;.UpdateAsync method

Processes an Update request asynchronously

```csharp
public Task<TSaveResponse> UpdateAsync(IUnitOfWork uow, TSaveRequest request, 
    CancellationToken cancellationToken = default)
```

| parameter | description |
| --- | --- |
| uow | Unit of work |
| request | Save request |
| cancellationToken | Cancellation token |

## See Also

* interface [IUnitOfWork](../../Serenity.Data/IUnitOfWork.md)
* interface [IUpdateHandlerAsync&lt;TRow,TSaveRequest,TSaveResponse&gt;](../IUpdateHandlerAsync-3.md)