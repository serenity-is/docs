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
| [More](ListResponse-1/More.md) { get; set; } | Whether more records are available beyond the returned page, when requested. |
| [Skip](ListResponse-1/Skip.md) { get; set; } |  |
| [Take](ListResponse-1/Take.md) { get; set; } |  |
| [TotalCount](ListResponse-1/TotalCount.md) { get; set; } |  |
| [Values](ListResponse-1/Values.md) { get; set; } | List of distinct values, if DistinctFields are passed in the list request. Values for each distinct row are appended in the requested field order. When multiple fields are requested, the list is flat and values are not grouped into tuples. |

## See Also

* class [ServiceResponse](./ServiceResponse.md)
* interface [IListResponse](./IListResponse.md)
* **Source:** *[ListResponse.cs](https://github.com/serenity-is/Serenity/blob/7942b778cba1362623aa070554117a88735f249a/src/services/Models/ListResponse.cs)*