# ListRequest class
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

The request model for a List service.

```csharp
public class ListRequest : ServiceRequest, IIncludeExcludeColumns
```

## Public Members

| name | description |
| --- | --- |
| [ListRequest](ListRequest/ListRequest.md)() | The default constructor. |
| [Aggregates](ListRequest/Aggregates.md) { get; set; } | The values to calculate from all the rows the request matches, and not only from the page that is returned, e.g. the sum of a field, which are returned in [`Aggregates`](./ListResponse-1/Aggregates.md). A handler that doesn't support aggregates ignores this, and returns none. |
| [ColumnSelection](ListRequest/ColumnSelection.md) { get; set; } | Group of columns to select. This is ColumnSelection.List, e.g. only the table fields, not view fields by default. |
| [ContainsField](ListRequest/ContainsField.md) { get; set; } | If specified, the text is only searched in this column. The column should still have a [`QuickSearchAttribute`](../Serenity.Data.Mapping/QuickSearchAttribute.md). |
| [ContainsText](ListRequest/ContainsText.md) { get; set; } | The text to search in columns with the [`QuickSearchAttribute`](../Serenity.Data.Mapping/QuickSearchAttribute.md). |
| [Criteria](ListRequest/Criteria.md) { get; set; } | The where criteria for the query. This is passed as an array of arrays in the JSON. |
| [DistinctFields](ListRequest/DistinctFields.md) { get; set; } | Distinct set of columns. If set a DISTINCT query is used, and only these columns can be returned from the query. |
| [EqualityFilter](ListRequest/EqualityFilter.md) { get; set; } | A dictionary of field name / value pairs used to filter those fields by the passed value. Please note that "NULL" values are ignored, so you can't filter a field with a NULL value. |
| [ExcludeColumns](ListRequest/ExcludeColumns.md) { get; set; } |  |
| [ExcludeEntities](ListRequest/ExcludeEntities.md) { get; set; } | Set to true to get no entities, only what is calculated from them, like the total count and the aggregates. |
| [ExcludeTotalCount](ListRequest/ExcludeTotalCount.md) { get; set; } | Exclude the total count from the result. When `true`, the total number of records is not calculated (no extra `COUNT(*)`) and [`TotalCount`](./ListResponse-1/TotalCount.md) is left as zero. When `false`, the total is calculated for paged requests (when [`Take`](./ListRequest/Take.md) is greater than zero). When `null` (the default, i.e. not sent), the total is calculated for paged requests unless [`IncludeMore`](./ListRequest/IncludeMore.md) is true or the handler's `RequestHandlerSettings.ExcludeTotalCountByDefault` is enabled. A zero [`Take`](./ListRequest/Take.md) that paging limits turn into an actual page size still returns the total, regardless of that setting, unless [`IncludeMore`](./ListRequest/IncludeMore.md) is requested. |
| [ExportColumns](ListRequest/ExportColumns.md) { get; set; } | Gets or sets the set of columns to export. This should only be used to specify list of columns for contexts like Excel export etc. |
| [GroupBy](ListRequest/GroupBy.md) { get; set; } | The fields to group the rows by for the aggregates, the outermost first, so they are also calculated for each group, see [`Groups`](./AggregateGroup/Groups.md). The groups are counted even when there are no [`Aggregates`](./ListRequest/Aggregates.md). |
| [IncludeColumns](ListRequest/IncludeColumns.md) { get; set; } |  |
| [IncludeDeleted](ListRequest/IncludeDeleted.md) { get; set; } | Include the deleted records. Default is false. This is only supported by services and entities that implement soft delete, e.g. IsActive etc. The value is ignored unless the current user has the undelete permission (UndeletePermissionAttribute, falling back to delete, modify and read permissions). |
| [IncludeMore](ListRequest/IncludeMore.md) { get; set; } | Include whether more records are available beyond the requested page in the response. |
| [Localize](ListRequest/Localize.md) { get; set; } | Set to "true" to localize fields with the Localize attribute. Note that this will also affect filtering and sorting as the field's expression will be changed to a COALESCE one. To get a localized version in a specific language, pass the language code as the value. |
| [Skip](ListRequest/Skip.md) { get; set; } | Number of records to skip |
| [Sort](ListRequest/Sort.md) { get; set; } | Columns to sort returned records by |
| [Take](ListRequest/Take.md) { get; set; } | Number of records to take |
| [TimeZone](ListRequest/TimeZone.md) { get; set; } | The time zone of the user, an IANA one like `Europe/Istanbul`, which is what a browser gives, or a Windows one. It tells where the days start for the intervals of [`GroupBy`](./ListRequest/GroupBy.md), see [`Interval`](./GroupBy/Interval.md), so the dates and times of the fields that are UTC are grouped by the days the user sees. It doesn't change the filters, or the dates that are returned. A service can use it for other things it tells of. When it is not given, the dates are grouped as they are stored. |

## See Also

* class [ServiceRequest](./ServiceRequest.md)
* interface [IIncludeExcludeColumns](./IIncludeExcludeColumns.md)
* **Source:** *[ListRequest.cs](https://github.com/serenity-is/Serenity/blob/fe192008ef3eb7ca797fe26e985938f11d067e66/src/services/Models/ListRequest.cs)*