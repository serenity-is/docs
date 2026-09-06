# RetrieveRequestHandler&lt;TRow,TRetrieveRequest,TRetrieveResponse&gt;.Process method

Processes the retrieve request. This is the entry point for the handler.

```csharp
public TRetrieveResponse Process(IDbConnection connection, TRetrieveRequest request)
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

* class [RetrieveRequestHandler&lt;TRow,TRetrieveRequest,TRetrieveResponse&gt;](../RetrieveRequestHandler-3.md)