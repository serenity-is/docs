# ListRequest class
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

```csharp
public class ListRequest : ServiceRequest, IIncludeExcludeColumns
```

## Public Members

| name | description |
| --- | --- |
| [ListRequest](ListRequest/ListRequest.md)() | The default constructor. |
| [ColumnSelection](ListRequest/ColumnSelection.md) { get; set; } |  |
| [ContainsField](ListRequest/ContainsField.md) { get; set; } |  |
| [ContainsText](ListRequest/ContainsText.md) { get; set; } |  |
| [Criteria](ListRequest/Criteria.md) { get; set; } |  |
| [DistinctFields](ListRequest/DistinctFields.md) { get; set; } |  |
| [EqualityFilter](ListRequest/EqualityFilter.md) { get; set; } |  |
| [ExcludeColumns](ListRequest/ExcludeColumns.md) { get; set; } |  |
| [ExcludeTotalCount](ListRequest/ExcludeTotalCount.md) { get; set; } |  |
| [ExportColumns](ListRequest/ExportColumns.md) { get; set; } | Gets or sets the set of columns to export. This should only be used to specify list of columns for contexts like Excel export etc. |
| [IncludeColumns](ListRequest/IncludeColumns.md) { get; set; } |  |
| [IncludeDeleted](ListRequest/IncludeDeleted.md) { get; set; } |  |
| [Skip](ListRequest/Skip.md) { get; set; } |  |
| [Sort](ListRequest/Sort.md) { get; set; } |  |
| [Take](ListRequest/Take.md) { get; set; } |  |

## See Also

* class [ServiceRequest](ServiceRequest.md)
* interface [IIncludeExcludeColumns](IIncludeExcludeColumns.md)
* **Source:** *[ListRequest.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Services/Models/ListRequest.cs)*