# UndeleteRequestHandler&lt;TRow,TUndeleteRequest,TUndeleteResponse&gt;.Process method
**namespace:** *[Serenity.Services](../../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

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
| ArgumentNullException | unitofWork is null |

## See Also

* class [TUndeleteResponse](../Serenity.Net.Services/../UndeleteRequestHandler-3.TUndeleteResponse.md)
* interface [IUnitOfWork](../Serenity.Net.Data/../../Serenity.Data/IUnitOfWork.md)
* class [TUndeleteRequest](../Serenity.Net.Services/../UndeleteRequestHandler-3.TUndeleteRequest.md)
* class [UndeleteRequestHandler&lt;TRow,TUndeleteRequest,TUndeleteResponse&gt;](../UndeleteRequestHandler-3.md)