# IListHandlerAsync&lt;TRow,TListRequest,TListResponse&gt;.ListAsync method
**namespace:** *[Serenity.Services](../../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Processes a List request asynchronously

```csharp
public Task<TListResponse> ListAsync(IDbConnection connection, TListRequest request, 
    CancellationToken cancellationToken = default(CancellationToken))
```

| parameter | description |
| --- | --- |
| connection | Connection |
| request | List request |
| cancellationToken | Cancellation token |

## See Also

* class [TListResponse](../Serenity.Net.Services/../IListHandlerAsync-3.TListResponse.md)
* class [TListRequest](../Serenity.Net.Services/../IListHandlerAsync-3.TListRequest.md)
* interface [IListHandlerAsync&lt;TRow,TListRequest,TListResponse&gt;](../IListHandlerAsync-3.md)