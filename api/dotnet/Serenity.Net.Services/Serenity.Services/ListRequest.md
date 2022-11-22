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
| [ContainsField](ListRequest/ContainsField.md) { get; set; } | If specified, the text is only searched in this column. The column should still have a QuickSearchAttribute. |
| [ContainsText](ListRequest/ContainsText.md) { get; set; } | The text to search in columns with the QuickSearchAttribute. |
| [Criteria](ListRequest/Criteria.md) { get; set; } | The where criteria for the query. This is passed as an array of arrays in the JSON. |
| [DistinctFields](ListRequest/DistinctFields.md) { get; set; } | Distinct set of columns. If set a DISTINCT query is used, and only these columns can be returned from the query. |
| [EqualityFilter](ListRequest/EqualityFilter.md) { get; set; } | A dictionary of field name / value pairs used to filter those fields by the passed value. Please note that "NULL" values are ignored, so you can't filter a field with a NULL value. |
| [ExcludeColumns](ListRequest/ExcludeColumns.md) { get; set; } |  |
| [ExcludeTotalCount](ListRequest/ExcludeTotalCount.md) { get; set; } | Exclude the total count from the result. Set this to true if you don't need the total number of records when Skip / Take parameters are passed. Otherwise, a second query will be required to get number of total records. |
| [ExportColumns](ListRequest/ExportColumns.md) { get; set; } | Gets or sets the set of columns to export. This should only be used to specify list of columns for contexts like Excel export etc. |
| [IncludeColumns](ListRequest/IncludeColumns.md) { get; set; } |  |
| [IncludeDeleted](ListRequest/IncludeDeleted.md) { get; set; } | Include the deleted records. Default is false. This is only supported by services and entities that implement soft delete, e.g. IsActive etc. |
| [Skip](ListRequest/Skip.md) { get; set; } | Number of records to skip |
| [Sort](ListRequest/Sort.md) { get; set; } | Columns to sort returned records by |
| [Take](ListRequest/Take.md) { get; set; } | Number of records to take |

## See Also

* class [ServiceRequest](ServiceRequest.md)
* interface [IIncludeExcludeColumns](IIncludeExcludeColumns.md)
* **Source:** *[ListRequest.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Services/Models/ListRequest.cs)*