# DateGroupInterval enumeration
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

The interval the values of a date field are grouped by, see [`Interval`](./GroupBy/Interval.md). The rows of an interval are one group, whose key is the start of the interval, e.g. the first day of the month.

```csharp
public enum DateGroupInterval
```

## Values

| name | value | description |
| --- | --- | --- |
| Year | `1` | The year, which starts on the first of January. |
| Quarter | `2` | The quarter of the year, which starts on the first of January, April, July or October. |
| Month | `3` | The month, which starts on its first day. |
| Week | `4` | The week, which starts on Monday. |
| Day | `5` | The day, which starts at midnight. |
| Hour | `6` | The hour. |

## See Also

* **Source:** *[DateGroupInterval.cs](https://github.com/serenity-is/Serenity/blob/fe315f91b4a5c5394577bb16974537aae1fd90e8/src/services/Models/DateGroupInterval.cs)*