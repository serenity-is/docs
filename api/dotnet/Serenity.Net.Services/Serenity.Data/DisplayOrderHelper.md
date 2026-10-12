# DisplayOrderHelper class
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

A static class with helper functions to update display orders of all records or groups of records in a table.

```csharp
public static class DisplayOrderHelper
```

## Public Members

| name | description |
| --- | --- |
| static [GetNextValue](DisplayOrderHelper/GetNextValue.md)(…) | Gets the next display order value for a table or a group of records. (2 methods) |
| static [GetNextValueAsync](DisplayOrderHelper/GetNextValueAsync.md)(…) | Asynchronously gets the next display order value for a table or a group of records. (2 methods) |
| static [ReorderValues](DisplayOrderHelper/ReorderValues.md)(…) | Sets a records display order to to requested value, and also renumbers other records in the group as required. (2 methods) |
| static [ReorderValuesAsync](DisplayOrderHelper/ReorderValuesAsync.md)(…) | Asynchronously sets a records display order to to requested value, and also renumbers other records in the group as required. (2 methods) |
| static [UpdateOrders](DisplayOrderHelper/UpdateOrders.md)(…) | Updates display order values in a table |
| static [UpdateOrdersAsync](DisplayOrderHelper/UpdateOrdersAsync.md)(…) | Asynchronously updates display order values in a table |
| class [OrderRecord](DisplayOrderHelper.OrderRecord.md) | An internal class that is used FixRecordOrdering to store old and new display orders for records to be sorted. |

## Remarks

Table and column names passed to these methods are assumed to be trusted row metadata (e.g. [`Table`](./IEntity/Table.md) and [`IDisplayOrderRow`](./IDisplayOrderRow.md) fields), not external user input. They are auto bracketed for correct quoting, but are NOT validated or sanitized against SQL injection, so callers must never pass user supplied strings as table or column names (the same way they could not pass such values to [`From`](./SqlQuery/From.md) or a field `Expression`).

These helpers do NOT handle race conditions. In particular, `GetNextValue` reads MAX(display order) + 1 and the caller inserts that value later in the same transaction, so under the default (read committed) isolation two concurrent inserts in the same group can compute the same next value. A unique index on the display order column (grouped with the same keys used by the display order filter) is therefore recommended so the database rejects the duplicate. When such an index exists, pass `hasUniqueConstraint: true` to the reorder methods so they avoid transient collisions.

Automatic retry of conflicting inserts is not implemented. It is feasible (a unique violation can be detected via `ISqlErrorExtractor` and the value recomputed), but a failed insert aborts the surrounding transaction, so retrying requires re-running the whole save in a fresh transaction and reliably attributing the violation to the display-order constraint (providers do not always report the offending column). Until that is warranted, handling the conflict (e.g. retrying the request or surfacing the error) is left to the application.

## See Also

* **Source:** *[DisplayOrderHelper.cs](https://github.com/serenity-is/Serenity/blob/372f07a8065a8f6b0418e39d746d4dc59a46308b/src/services/RequestHandlers/IntegratedFeatures/DisplayOrder/DisplayOrderHelper.cs)*