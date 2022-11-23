# UndeleteRequestHandler&lt;TRow,TUndeleteRequest,TUndeleteResponse&gt;.IsDeleted method
**namespace:** *[Serenity.Services](../../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Checks that row type implements one of IIsActiveDeletedRow, IIsDeletedRow or IDeleteLogRow interfaces and it is actual marked as deleted

```csharp
protected virtual bool IsDeleted()
```

## Exceptions

| exception | condition |
| --- | --- |
| NotImplementedException | Row does not implement any of known interfaces |

## See Also

* class [UndeleteRequestHandler&lt;TRow,TUndeleteRequest,TUndeleteResponse&gt;](../UndeleteRequestHandler-3.md)