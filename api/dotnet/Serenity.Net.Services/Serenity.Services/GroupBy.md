# GroupBy class
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

A field the rows a list request matches are grouped by, for the aggregates of each group, see [`GroupBy`](./ListRequest/GroupBy.md).

```csharp
public class GroupBy
```

## Public Members

| name | description |
| --- | --- |
| [GroupBy](GroupBy/GroupBy.md)() | Creates an empty GroupBy object |
| [GroupBy](GroupBy/GroupBy.md)(…) | Creates a GroupBy object for the specified field name. |
| [Descending](GroupBy/Descending.md) { get; set; } | Gets/sets whether the groups are in descending order of the field |
| [Field](GroupBy/Field.md) { get; set; } | Gets/sets the field name |
| [Interval](GroupBy/Interval.md) { get; set; } | Gets/sets the interval the values of a date field are grouped by, e.g. the months. The key of a group is then the start of its interval, see [`Key`](./AggregateGroup/Key.md). It can only be used with a date field, and the rows are not grouped at all otherwise. |

## See Also

* **Source:** *[GroupBy.cs](https://github.com/serenity-is/Serenity/blob/fe315f91b4a5c5394577bb16974537aae1fd90e8/src/services/Models/GroupBy.cs)*