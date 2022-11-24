# SaveRequestHandler&lt;TRow,TSaveRequest,TSaveResponse&gt;.Process method
**namespace:** *[Serenity.Services](../../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Processes the save request. This is the entry point for the handler.

```csharp
public TSaveResponse Process(IUnitOfWork unitOfWork, TSaveRequest request, 
    SaveRequestType requestType = SaveRequestType.Auto)
```

| parameter | description |
| --- | --- |
| unitOfWork | Unit of work |
| request | Request |
| requestType | Type of request, Create, Update or Auto |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | unitofWork or request is null |

## See Also

* class [TSaveResponse](../Serenity.Net.Services/../SaveRequestHandler-3.TSaveResponse.md)
* interface [IUnitOfWork](../Serenity.Net.Data/../../Serenity.Data/IUnitOfWork.md)
* class [TSaveRequest](../Serenity.Net.Services/../SaveRequestHandler-3.TSaveRequest.md)
* enum [SaveRequestType](../SaveRequestType.md)
* class [SaveRequestHandler&lt;TRow,TSaveRequest,TSaveResponse&gt;](../SaveRequestHandler-3.md)