# IUndeleteHandlerAsync&lt;TRow,TUndeleteRequest,TUndeleteResponse&gt;.UndeleteAsync method

Processes an undelete request asynchronously

```csharp
public Task<TUndeleteResponse> UndeleteAsync(IUnitOfWork uow, TUndeleteRequest request, 
    CancellationToken cancellationToken = default)
```

| parameter | description |
| --- | --- |
| uow | Unit of work |
| request | The undelete request |
| cancellationToken | Cancellation token |

## See Also

* interface [IUnitOfWork](../../Serenity.Data/IUnitOfWork.md)
* interface [IUndeleteHandlerAsync&lt;TRow,TUndeleteRequest,TUndeleteResponse&gt;](../IUndeleteHandlerAsync-3.md)