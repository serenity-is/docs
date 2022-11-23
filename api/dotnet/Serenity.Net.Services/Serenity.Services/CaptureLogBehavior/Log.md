# CaptureLogBehavior.Log method
**namespace:** *[Serenity.Services](../../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Logs a capture log operation

```csharp
public void Log(IUnitOfWork uow, IRow old, IRow row, object userId)
```

| parameter | description |
| --- | --- |
| uow | Unit of work |
| old | Old entity |
| row | New entity |
| userId | User ID |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | old and row is null |
| InvalidOperationException | Capture log row type does not implement ICaptureLogRow interface |

## See Also

* interface [IUnitOfWork](../Serenity.Net.Data/../../Serenity.Data/IUnitOfWork.md)
* interface [IRow](../Serenity.Net.Entity/../../Serenity.Data/IRow.md)
* class [CaptureLogBehavior](../CaptureLogBehavior.md)