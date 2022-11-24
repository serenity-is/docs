# ICaptureLogHandler.Log method
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Logs the capture log operation

```csharp
public void Log(IUnitOfWork uow, IRow old, IRow row, object userId)
```

| parameter | description |
| --- | --- |
| uow | Unit of work |
| old | Old record |
| row | New record |
| userId | The user ID performing the operation |

## See Also

* interface [IUnitOfWork](../Serenity.Net.Data/../IUnitOfWork.md)
* interface [IRow](../Serenity.Net.Entity/../IRow.md)
* interface [ICaptureLogHandler](../ICaptureLogHandler.md)