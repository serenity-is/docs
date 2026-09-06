# CaptureLogBehavior.LogAsync method
**namespace:** *[Serenity.Services](../../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Asynchronously logs a capture log operation

```csharp
public Task LogAsync(IUnitOfWork uow, IRow old, IRow row, object userId, 
    CancellationToken cancellationToken = default(CancellationToken))
```

| parameter | description |
| --- | --- |
| uow | Unit of work |
| old | Old entity |
| row | New entity |
| userId | User ID |
| cancellationToken | Cancellation token |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | *old* and *row* are both `null`. |
| InvalidOperationException | Capture log row type does not implement ICaptureLogRow interface |

## See Also

* interface [IUnitOfWork](../../Serenity.Data/IUnitOfWork.md)
* interface [IRow](../../Serenity.Data/IRow.md)
* class [CaptureLogBehavior](../CaptureLogBehavior.md)