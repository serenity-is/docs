# RetrieveRequestHandlerAsync&lt;TRow,TRetrieveRequest,TRetrieveResponse&gt;.ExecuteQueryAsync method
**namespace:** *[Serenity.Services](../../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Executes the query and sets the response entity if found.

```csharp
protected virtual Task ExecuteQueryAsync(
    CancellationToken cancellationToken = default(CancellationToken))
```

## Exceptions

| exception | condition |
| --- | --- |
| ValidationError | If entity is not found |

## See Also

* class [RetrieveRequestHandlerAsync&lt;TRow,TRetrieveRequest,TRetrieveResponse&gt;](../RetrieveRequestHandlerAsync-3.md)