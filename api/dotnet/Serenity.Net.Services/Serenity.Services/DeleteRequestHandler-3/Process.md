# DeleteRequestHandler&lt;TRow,TDeleteRequest,TDeleteResponse&gt;.Process method
**namespace:** *[Serenity.Services](../../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

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
| ArgumentNullException | unitofWork or request is null |

## See Also

* class [TDeleteResponse](../Serenity.Net.Services/../DeleteRequestHandler-3.TDeleteResponse.md)
* interface [IUnitOfWork](../Serenity.Net.Data/../../Serenity.Data/IUnitOfWork.md)
* class [TDeleteRequest](../Serenity.Net.Services/../DeleteRequestHandler-3.TDeleteRequest.md)
* class [DeleteRequestHandler&lt;TRow,TDeleteRequest,TDeleteResponse&gt;](../DeleteRequestHandler-3.md)