# ListRequestHandler&lt;TRow,TListRequest,TListResponse&gt;.Process method

Processes the list request. This is the entry point for the handler.

```csharp
public TListResponse Process(IDbConnection connection, TListRequest request)
```

| parameter | description |
| --- | --- |
| connection | Connection |
| request | Request |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | *connection* or *request* is `null`. |

## See Also

* class [ListRequestHandler&lt;TRow,TListRequest,TListResponse&gt;](../ListRequestHandler-3.md)