# ICaptureLogHandler.Log method

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

* interface [IUnitOfWork](../IUnitOfWork.md)
* interface [IRow](../IRow.md)
* interface [ICaptureLogHandler](../ICaptureLogHandler.md)