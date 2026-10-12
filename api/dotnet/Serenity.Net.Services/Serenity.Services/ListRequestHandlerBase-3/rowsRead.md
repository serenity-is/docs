# ListRequestHandlerBase&lt;TRow,TListRequest,TListResponse&gt;.rowsRead field

Number of rows returned by the executed query before any post-processing (e.g. [`ProcessEntity`](./ProcessEntity.md) dropping rows). Used to compute the [`More`](../ListResponse-1/More.md) indicator based on the sentinel row rather than the filtered entity count.

```csharp
protected int? rowsRead;
```

## See Also

* class [ListRequestHandlerBase&lt;TRow,TListRequest,TListResponse&gt;](../ListRequestHandlerBase-3.md)