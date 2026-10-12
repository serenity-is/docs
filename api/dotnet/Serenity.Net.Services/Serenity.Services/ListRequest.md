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
| [ColumnSelection](ListRequest/ColumnSelection.md) { get; set; } | Group of columns to select. This is ColumnSelection.List, e.g. only the table fields, not view fields by default. |
| [ContainsField](ListRequest/ContainsField.md) { get; set; } | If specified, the text is only searched in this column. The column should still have a [`QuickSearchAttribute`](../Serenity.Data.Mapping/QuickSearchAttribute.md). |
| [ContainsText](ListRequest/ContainsText.md) { get; set; } | The text to search in columns with the [`QuickSearchAttribute`](../Serenity.Data.Mapping/QuickSearchAttribute.md). |
| [Criteria](ListRequest/Criteria.md) { get; set; } | The where criteria for the query. This is passed as an array of arrays in the JSON. |
| [DistinctFields](ListRequest/DistinctFields.md) { get; set; } | Distinct set of columns. If set a DISTINCT query is used, and only these columns can be returned from the query. |
| [EqualityFilter](ListRequest/EqualityFilter.md) { get; set; } | A dictionary of field name / value pairs used to filter those fields by the passed value. Please note that "NULL" values are ignored, so you can't filter a field with a NULL value. |
| [ExcludeColumns](ListRequest/ExcludeColumns.md) { get; set; } |  |
| [ExcludeTotalCount](ListRequest/ExcludeTotalCount.md) { get; set; } | Exclude the total count from the result. When `true`, the total number of records is not calculated (no extra `COUNT(*)`) and [`TotalCount`](./ListResponse-1/TotalCount.md) is left as zero. When `false`, the total is calculated for paged requests (when [`Take`](./ListRequest/Take.md) is greater than zero). When `null` (the default, i.e. not sent), the total is calculated for paged requests unless [`IncludeMore`](./ListRequest/IncludeMore.md) is true or the handler's `RequestHandlerSettings.ExcludeTotalCountByDefault` is enabled. A zero [`Take`](./ListRequest/Take.md) that paging limits turn into an actual page size still returns the total, regardless of that setting, unless [`IncludeMore`](./ListRequest/IncludeMore.md) is requested. |
| [ExportColumns](ListRequest/ExportColumns.md) { get; set; } | Gets or sets the set of columns to export. This should only be used to specify list of columns for contexts like Excel export etc. |
| [IncludeColumns](ListRequest/IncludeColumns.md) { get; set; } |  |
| [IncludeDeleted](ListRequest/IncludeDeleted.md) { get; set; } | Include the deleted records. Default is false. This is only supported by services and entities that implement soft delete, e.g. IsActive etc. The value is ignored unless the current user has the undelete permission (UndeletePermissionAttribute, falling back to delete, modify and read permissions). |
| [IncludeMore](ListRequest/IncludeMore.md) { get; set; } | Include whether more records are available beyond the requested page in the response. |
| [Localize](ListRequest/Localize.md) { get; set; } | Set to "true" to localize fields with the Localize attribute. Note that this will also affect filtering and sorting as the field's expression will be changed to a COALESCE one. To get a localized version in a specific language, pass the language code as the value. |
| [Skip](ListRequest/Skip.md) { get; set; } | Number of records to skip |
| [Sort](ListRequest/Sort.md) { get; set; } | Columns to sort returned records by |
| [Take](ListRequest/Take.md) { get; set; } | Number of records to take |

## See Also

* class [ServiceRequest](./ServiceRequest.md)
* interface [IIncludeExcludeColumns](./IIncludeExcludeColumns.md)
* **Source:** *[ListRequest.cs](https://github.com/serenity-is/Serenity/blob/cab28e9506312283bcd9c44fae98b33b198f595a/src/services/Models/ListRequest.cs)*