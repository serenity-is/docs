# RetrieveRequestHandler&lt;TRow,TRetrieveRequest,TRetrieveResponse&gt;.Process method
**namespace:** *[Serenity.Services](../../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

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
| ArgumentNullException | connection or the request is null |

## See Also

* class [TRetrieveResponse](../Serenity.Net.Services/../RetrieveRequestHandler-3.TRetrieveResponse.md)
* class [TRetrieveRequest](../Serenity.Net.Services/../RetrieveRequestHandler-3.TRetrieveRequest.md)
* class [RetrieveRequestHandler&lt;TRow,TRetrieveRequest,TRetrieveResponse&gt;](../RetrieveRequestHandler-3.md)