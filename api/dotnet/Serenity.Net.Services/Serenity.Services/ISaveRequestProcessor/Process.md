# ISaveRequestProcessor.Process method
**namespace:** *[Serenity.Services](../../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Processes the [`ISaveRequest`](../ISaveRequest.md) and returns a [`SaveResponse`](../SaveResponse.md)

```csharp
public SaveResponse Process(IUnitOfWork uow, ISaveRequest request, SaveRequestType type)
```

| parameter | description |
| --- | --- |
| uow | Unit of work |
| request | List request |
| type | Save request type, Create or Update |

## See Also

* class [SaveResponse](../SaveResponse.md)
* interface [IUnitOfWork](../Serenity.Net.Data/../../Serenity.Data/IUnitOfWork.md)
* interface [ISaveRequest](../ISaveRequest.md)
* enum [SaveRequestType](../SaveRequestType.md)
* interface [ISaveRequestProcessor](../ISaveRequestProcessor.md)