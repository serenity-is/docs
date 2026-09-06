# UndeleteRequestHandler&lt;TRow,TUndeleteRequest,TUndeleteResponse&gt;.Process method

Processes the undelete request. This is the entry point for the handler.

```csharp
public TUndeleteResponse Process(IUnitOfWork unitOfWork, TUndeleteRequest request)
```

| parameter | description |
| --- | --- |
| unitOfWork | Unit of work |
| request | Request |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | *unitOfWork* is `null`. |

## See Also

* interface [IUnitOfWork](../../Serenity.Data/IUnitOfWork.md)
* class [UndeleteRequestHandler&lt;TRow,TUndeleteRequest,TUndeleteResponse&gt;](../UndeleteRequestHandler-3.md)