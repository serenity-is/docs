# DeleteRequestHandlerAsync&lt;TRow,TDeleteRequest,TDeleteResponse&gt;.ProcessAsync method

Processes the delete request asynchronously. This is the entry point for the handler.

```csharp
public Task<TDeleteResponse> ProcessAsync(IUnitOfWork unitOfWork, TDeleteRequest request, 
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
| ArgumentNullException | *unitOfWork* or *request* is `null`. |

## See Also

* interface [IUnitOfWork](../../Serenity.Data/IUnitOfWork.md)
* class [DeleteRequestHandlerAsync&lt;TRow,TDeleteRequest,TDeleteResponse&gt;](../DeleteRequestHandlerAsync-3.md)