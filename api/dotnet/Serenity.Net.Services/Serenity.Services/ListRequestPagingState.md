# ListRequestPagingState class
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Describes the paging strategy selected for a list request, as returned by [`ApplyPagingParams`](./ServiceQueryHelper/ApplyPagingParams.md).

```csharp
public sealed class ListRequestPagingState
```

## Public Members

| name | description |
| --- | --- |
| [AppliedTake](ListRequestPagingState/AppliedTake.md) { get; } | Gets the query take value when this paging state was created. |
| [Params](ListRequestPagingState/Params.md) { get; } | Gets the paging parameters the query was applied with. |
| [UsesSentinel](ListRequestPagingState/UsesSentinel.md) { get; } | Gets whether an extra row was requested as a sentinel. |

## See Also

* **Source:** *[ListRequestPagingState.cs](https://github.com/serenity-is/Serenity/blob/cab28e9506312283bcd9c44fae98b33b198f595a/src/services/Models/ListRequestPagingState.cs)*