# ListRequest.GroupBy property

The fields to group the rows by for the aggregates, the outermost first, so they are also calculated for each group, see [`Groups`](../AggregateGroup/Groups.md). The groups are counted even when there are no [`Aggregates`](./Aggregates.md).

```csharp
public List<GroupBy>? GroupBy { get; set; }
```

## See Also

* class [GroupBy](../GroupBy.md)
* class [ListRequest](../ListRequest.md)