# AggregateBy class
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

A value to calculate from all the rows a list request matches, and from the rows of each of its groups, e.g. the sum of a field. It is in the response under the key of its type, then the name of its field, see [`Values`](./AggregateGroup/Values.md).

```csharp
public class AggregateBy
```

## Public Members

| name | description |
| --- | --- |
| [AggregateBy](AggregateBy/AggregateBy.md)() | Creates an empty AggregateBy object |
| [AggregateBy](AggregateBy/AggregateBy.md)(…) | Creates an AggregateBy object for the specified field name and type. |
| [Field](AggregateBy/Field.md) { get; set; } | Gets/sets the field name. It is only optional for Count, which is the number of the rows without one, like [`Count`](./AggregateGroup/Count.md). |
| [Type](AggregateBy/Type.md) { get; set; } | Gets/sets the type of the aggregate |

## See Also

* **Source:** *[AggregateBy.cs](https://github.com/serenity-is/Serenity/blob/6144b41ef39a82d81dd7e4950b256ff86e79a141/src/services/Models/AggregateBy.cs)*