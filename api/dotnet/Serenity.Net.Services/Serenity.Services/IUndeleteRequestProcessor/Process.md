# IUndeleteRequestProcessor.Process method
**namespace:** *[Serenity.Services](../../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Processes the [`UndeleteRequest`](../UndeleteRequest.md) and returns a [`UndeleteResponse`](../UndeleteResponse.md)

```csharp
public UndeleteResponse Process(IUnitOfWork uow, UndeleteRequest request)
```

| parameter | description |
| --- | --- |
| uow | Unit of work |
| request | Delete request |

## See Also

* class [UndeleteResponse](../UndeleteResponse.md)
* interface [IUnitOfWork](../Serenity.Net.Data/../../Serenity.Data/IUnitOfWork.md)
* class [UndeleteRequest](../UndeleteRequest.md)
* interface [IUndeleteRequestProcessor](../IUndeleteRequestProcessor.md)