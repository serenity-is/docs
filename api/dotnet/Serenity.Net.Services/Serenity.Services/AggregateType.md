# AggregateType enumeration
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

The kind of a value that is calculated from the rows of a list request, see [`AggregateBy`](./AggregateBy.md). The values of the ones that are also in SummaryType are the same.

```csharp
public enum AggregateType
```

## Values

| name | value | description |
| --- | --- | --- |
| Count | `0` | The number of the rows, or of the rows whose field is not null when a field is given. |
| Sum | `1` | The sum of the values of the field. |
| Avg | `2` | The average of the values of the field, without the null ones. |
| Min | `3` | The smallest value of the field. |
| Max | `4` | The largest value of the field. |
| DistinctCount | `5` | The number of the different values of the field, without null. |

## See Also

* **Source:** *[AggregateType.cs](https://github.com/serenity-is/Serenity/blob/b05e6ba57343d309378314e7469e032d43885daf/src/services/Models/AggregateType.cs)*