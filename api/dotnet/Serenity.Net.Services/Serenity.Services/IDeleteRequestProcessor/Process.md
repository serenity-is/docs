# IDeleteRequestProcessor.Process method
**namespace:** *[Serenity.Services](../../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Processes the [`DeleteRequest`](../DeleteRequest.md) and returns a [`DeleteResponse`](../DeleteResponse.md)

```csharp
public DeleteResponse Process(IUnitOfWork uow, DeleteRequest request)
```

| parameter | description |
| --- | --- |
| uow | Unit of work |
| request | Delete request |

## See Also

* class [DeleteResponse](../DeleteResponse.md)
* interface [IUnitOfWork](../Serenity.Net.Data/../../Serenity.Data/IUnitOfWork.md)
* class [DeleteRequest](../DeleteRequest.md)
* interface [IDeleteRequestProcessor](../IDeleteRequestProcessor.md)