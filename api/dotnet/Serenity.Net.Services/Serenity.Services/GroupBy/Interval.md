# GroupBy.Interval property

Gets/sets the interval the values of a date field are grouped by, e.g. the months. The key of a group is then the start of its interval, see [`Key`](../AggregateGroup/Key.md). It can only be used with a date field, and the rows are not grouped at all otherwise.

```csharp
public DateGroupInterval? Interval { get; set; }
```

## See Also

* enum [DateGroupInterval](../DateGroupInterval.md)
* class [GroupBy](../GroupBy.md)