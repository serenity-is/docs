# AggregateGroup class
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

The aggregates of a list request for a set of rows: all the rows the request matches at the root, see [`Aggregates`](./ListResponse-1/Aggregates.md), and the rows of a group under it, one level for each [`GroupBy`](./ListRequest/GroupBy.md). They are calculated from all the rows, and not from the page that is returned.

```csharp
public class AggregateGroup
```

## Public Members

| name | description |
| --- | --- |
| [AggregateGroup](AggregateGroup/AggregateGroup.md)() | The default constructor. |
| [Count](AggregateGroup/Count.md) { get; set; } | The number of the rows. |
| [Groups](AggregateGroup/Groups.md) { get; set; } | The groups of the next level, in their order. It is null for a group of the last level, and at the root when the rows are not grouped, which is also when they are asked to be, but can't. |
| [Key](AggregateGroup/Key.md) { get; set; } | The value of the group field for the rows of the group, as it is in the entities, so a row can be matched to its group. It is null at the root, and for the group of the rows whose field is null. |
| [More](AggregateGroup/More.md) { get; set; } | True when there are more groups than the ones in [`Groups`](./AggregateGroup/Groups.md), as their number is limited. The values of this group are still of all of its rows. |
| [Values](AggregateGroup/Values.md) { get; set; } | The values of the aggregates, by the key of their type, see [`GetKey`](./AggregateGroup/GetKey.md), then by the name of their field, e.g. `Values["sum"]["Freight"]`, as the totals of a grid are. An aggregate that is not calculated, e.g. as its field can't be, is left out. The count without a field is only in [`Count`](./AggregateGroup/Count.md). |
| const [AvgKey](AggregateGroup/AvgKey.md) | The key of [`Values`](./AggregateGroup/Values.md) for Avg. |
| const [CountKey](AggregateGroup/CountKey.md) | The key of [`Values`](./AggregateGroup/Values.md) for Count. |
| const [DistinctCountKey](AggregateGroup/DistinctCountKey.md) | The key of [`Values`](./AggregateGroup/Values.md) for DistinctCount. |
| const [MaxKey](AggregateGroup/MaxKey.md) | The key of [`Values`](./AggregateGroup/Values.md) for Max. |
| const [MinKey](AggregateGroup/MinKey.md) | The key of [`Values`](./AggregateGroup/Values.md) for Min. |
| const [SumKey](AggregateGroup/SumKey.md) | The key of [`Values`](./AggregateGroup/Values.md) for Sum. |
| static [GetKey](AggregateGroup/GetKey.md)(…) | Gets the key of [`Values`](./AggregateGroup/Values.md) for an aggregate type, which are the ones of the aggregators of the grids for the types they have. |

## See Also

* **Source:** *[AggregateGroup.cs](https://github.com/serenity-is/Serenity/blob/6144b41ef39a82d81dd7e4950b256ff86e79a141/src/services/Models/AggregateGroup.cs)*