# IDeleteHandlerAsync&lt;TRow,TDeleteRequest,TDeleteResponse&gt;.DeleteAsync method

Processes a delete request asynchronously

```csharp
public Task<TDeleteResponse> DeleteAsync(IUnitOfWork uow, TDeleteRequest request, 
    CancellationToken cancellationToken = default)
```

| parameter | description |
| --- | --- |
| uow | Unit of work |
| request | The delete request |
| cancellationToken | Cancellation token |

## See Also

* interface [IUnitOfWork](../../Serenity.Data/IUnitOfWork.md)
* interface [IDeleteHandlerAsync&lt;TRow,TDeleteRequest,TDeleteResponse&gt;](../IDeleteHandlerAsync-3.md)