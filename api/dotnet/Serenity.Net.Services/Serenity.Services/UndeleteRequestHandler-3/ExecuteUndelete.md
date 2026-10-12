# UndeleteRequestHandler&lt;TRow,TUndeleteRequest,TUndeleteResponse&gt;.ExecuteUndelete method

Executes the actual SQL undelete/update operation

```csharp
protected virtual void ExecuteUndelete()
```

## Remarks

Only rows that are currently marked as deleted are restored. For [`IIsActiveDeletedRow`](../../Serenity.Data/IIsActiveDeletedRow.md) the active value (`1`) is restored, because the state the row had before deletion is not stored anywhere; a row that was inactive (`0`) before being deleted ends up active.

## See Also

* class [UndeleteRequestHandler&lt;TRow,TUndeleteRequest,TUndeleteResponse&gt;](../UndeleteRequestHandler-3.md)