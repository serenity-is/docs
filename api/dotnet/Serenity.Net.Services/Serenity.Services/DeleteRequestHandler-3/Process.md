# DeleteRequestHandler&lt;TRow,TDeleteRequest,TDeleteResponse&gt;.Process method

Processes the delete request. This is the entry point for the handler.

```csharp
public TDeleteResponse Process(IUnitOfWork unitOfWork, TDeleteRequest request)
```

| parameter | description |
| --- | --- |
| unitOfWork | Unit of work |
| request | Request |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | *unitOfWork* or *request* is `null`. |

## See Also

* interface [IUnitOfWork](../../Serenity.Data/IUnitOfWork.md)
* class [DeleteRequestHandler&lt;TRow,TDeleteRequest,TDeleteResponse&gt;](../DeleteRequestHandler-3.md)