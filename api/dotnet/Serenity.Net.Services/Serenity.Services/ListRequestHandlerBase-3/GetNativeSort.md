# ListRequestHandlerBase&lt;TRow,TListRequest,TListResponse&gt;.GetNativeSort method

Gets the native sort order, which includes name field by default, unless the row has [SortOrder] attributes.

```csharp
protected virtual SortBy[] GetNativeSort()
```

## Return Value

The native sort order, or `null` if there is none.

## See Also

* class [SortBy](../SortBy.md)
* class [ListRequestHandlerBase&lt;TRow,TListRequest,TListResponse&gt;](../ListRequestHandlerBase-3.md)