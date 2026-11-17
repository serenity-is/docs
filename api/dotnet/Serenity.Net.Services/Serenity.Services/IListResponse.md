# IListResponse interface
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

The interface for list response. This is used to easily access list response members as the [`ListResponse`](./ListResponse-1.md) class itself is generic.

```csharp
public interface IListResponse
```

## Members

| name | description |
| --- | --- |
| [Aggregates](IListResponse/Aggregates.md) { get; set; } | The aggregates of all the rows the request matches, set by a behavior that supports them. |
| [Entities](IListResponse/Entities.md) { get; set; } | List of entities |
| [More](IListResponse/More.md) { get; set; } | Whether more records are available beyond the returned page, when requested. |
| [Skip](IListResponse/Skip.md) { get; set; } | Number of records skipped, passed from the ListRequest |
| [Take](IListResponse/Take.md) { get; set; } | Number of records taken, passed from the ListRequest |
| [TotalCount](IListResponse/TotalCount.md) { get; set; } | Total count of the records. This may be different than the number of returned records when paging is active, e.g. when Skip/Take parameters are assigned. |

## See Also

* **Source:** *[IListResponse.cs](https://github.com/serenity-is/Serenity/blob/2b2dc408169894d8cc7befbe94a14eef08d49400/src/services/Models/IListResponse.cs)*