# IListResponse interface
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

The interface for list response. This is used to easily access list response members as the [`ListResponse`](ListResponse-1.md) class itself is generic.

```csharp
public interface IListResponse
```

## Members

| name | description |
| --- | --- |
| [Entities](IListResponse/Entities.md) { get; } | List of entities |
| [Skip](IListResponse/Skip.md) { get; } | Number of records skipped, passed from the ListRequest |
| [Take](IListResponse/Take.md) { get; } | Number of records taken, passed from the ListRequest |
| [TotalCount](IListResponse/TotalCount.md) { get; } | Total count of the records. This may be different than the number of returned records when paging is active, e.g. when Skip/Take parameters are assigned. |

## See Also

* **Source:** *[IListResponse.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Services/Models/IListResponse.cs)*