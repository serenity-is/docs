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
| static [ReorderValues](DisplayOrderHelper/ReorderValues.md)(…) | Sets a records display order to to requested value, and also renumbers other records in the group as required. (2 methods) |
| static [UpdateOrders](DisplayOrderHelper/UpdateOrders.md)(…) | Updates display order values in a table |
| class [OrderRecord](DisplayOrderHelper.OrderRecord.md) | An internal class that is used FixRecordOrdering to store old and new display orders for records to be sorted. |

## See Also

* **Source:** *[DisplayOrderHelper.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Services/RequestHandlers/IntegratedFeatures/DisplayOrder/DisplayOrderHelper.cs)*