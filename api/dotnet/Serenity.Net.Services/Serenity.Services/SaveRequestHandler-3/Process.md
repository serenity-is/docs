# SaveRequestHandler&lt;TRow,TSaveRequest,TSaveResponse&gt;.Process method

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
| ArgumentNullException | *unitOfWork* or *request* is `null`. |

## See Also

* interface [IUnitOfWork](../../Serenity.Data/IUnitOfWork.md)
* enum [SaveRequestType](../SaveRequestType.md)
* class [SaveRequestHandler&lt;TRow,TSaveRequest,TSaveResponse&gt;](../SaveRequestHandler-3.md)