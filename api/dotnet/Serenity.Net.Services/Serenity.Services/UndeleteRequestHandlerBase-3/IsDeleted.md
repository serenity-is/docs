# UndeleteRequestHandlerBase&lt;TRow,TUndeleteRequest,TUndeleteResponse&gt;.IsDeleted method

Checks that row type implements one of IIsActiveDeletedRow, IIsDeletedRow or IDeleteLogRow interfaces and it is actual marked as deleted

```csharp
protected virtual bool IsDeleted()
```

## Exceptions

| exception | condition |
| --- | --- |
| NotImplementedException | Row does not implement any of known interfaces |

## See Also

* class [UndeleteRequestHandlerBase&lt;TRow,TUndeleteRequest,TUndeleteResponse&gt;](../UndeleteRequestHandlerBase-3.md)