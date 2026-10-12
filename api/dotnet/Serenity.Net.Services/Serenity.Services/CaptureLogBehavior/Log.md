# CaptureLogBehavior.Log method

Logs a capture log operation

```csharp
public void Log(IUnitOfWork uow, IRow? old, IRow? row, object? userId)
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
| ArgumentNullException | *old* and *row* are both `null`. |
| InvalidOperationException | Capture log row type does not implement ICaptureLogRow interface |

## Remarks

The currently active log row is closed before inserting the new one. As this is not atomic across concurrent transactions for the same ID, a unique index on the mapped ID and ValidUntil columns is recommended to enforce a single active row.

## See Also

* interface [IUnitOfWork](../../Serenity.Data/IUnitOfWork.md)
* interface [IRow](../../Serenity.Data/IRow.md)
* class [CaptureLogBehavior](../CaptureLogBehavior.md)