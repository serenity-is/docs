# UndeleteRequestHandlerAsync&lt;TRow,TUndeleteRequest,TUndeleteResponse&gt;.ProcessAsync method

Processes the undelete request asynchronously. This is the entry point for the handler.

```csharp
public Task<TUndeleteResponse> ProcessAsync(IUnitOfWork unitOfWork, TUndeleteRequest request, 
    CancellationToken cancellationToken = default)
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

* interface [IUnitOfWork](../../Serenity.Data/IUnitOfWork.md)
* class [UndeleteRequestHandlerAsync&lt;TRow,TUndeleteRequest,TUndeleteResponse&gt;](../UndeleteRequestHandlerAsync-3.md)