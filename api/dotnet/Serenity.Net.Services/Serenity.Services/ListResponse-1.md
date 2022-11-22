# ListResponse&lt;T&gt; class
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

The response model for a list service.

```csharp
public class ListResponse<T> : ServiceResponse, IListResponse
```

| parameter | description |
| --- | --- |
| T | Type of the returned entities. |

## Public Members

| name | description |
| --- | --- |
| [ListResponse](ListResponse-1/ListResponse.md)() | The default constructor. |
| [Entities](ListResponse-1/Entities.md) { get; set; } | Entities |
| [Skip](ListResponse-1/Skip.md) { get; set; } |  |
| [Take](ListResponse-1/Take.md) { get; set; } |  |
| [TotalCount](ListResponse-1/TotalCount.md) { get; set; } |  |
| [Values](ListResponse-1/Values.md) { get; set; } | List of distinct values, if DistinctFields are passed in the list request. Each element of the list is an array of distinct values if multiple distinct fields are requested. |

## See Also

* class [ServiceResponse](ServiceResponse.md)
* interface [IListResponse](IListResponse.md)
* **Source:** *[ListResponse.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Services/Models/ListResponse.cs)*