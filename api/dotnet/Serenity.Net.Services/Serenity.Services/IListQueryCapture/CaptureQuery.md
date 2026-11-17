# IListQueryCapture.CaptureQuery method

Builds the query the handler would execute for the request, without executing it. See [`CaptureQuery`](../ListRequestHandler-3/CaptureQuery.md).

```csharp
public SqlQuery CaptureQuery(IDbConnection connection, ListRequest request)
```

| parameter | description |
| --- | --- |
| connection | Connection |
| request | List request |

## See Also

* class [SqlQuery](../../Serenity.Data/SqlQuery.md)
* class [ListRequest](../ListRequest.md)
* interface [IListQueryCapture](../IListQueryCapture.md)