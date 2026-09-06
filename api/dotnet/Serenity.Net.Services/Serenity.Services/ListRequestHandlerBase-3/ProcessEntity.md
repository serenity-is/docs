# ListRequestHandlerBase&lt;TRow,TListRequest,TListResponse&gt;.ProcessEntity method

Can be overridden in a derived class to make some changes in a returned entity just before it gets added to the Response.Entities list.

```csharp
protected virtual TRow ProcessEntity(TRow row)
```

| parameter | description |
| --- | --- |
| row | The row to process. |

## Return Value

The processed row, or `null` to skip adding it to the response.

## See Also

* class [ListRequestHandlerBase&lt;TRow,TListRequest,TListResponse&gt;](../ListRequestHandlerBase-3.md)