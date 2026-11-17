# AggregateGroup.Values property

The values of the aggregates, by the key of their type, see [`GetKey`](./GetKey.md), then by the name of their field, e.g. `Values["sum"]["Freight"]`, as the totals of a grid are. An aggregate that is not calculated, e.g. as its field can't be, is left out. The count without a field is only in [`Count`](./Count.md).

```csharp
public Dictionary<string, Dictionary<string, object?>>? Values { get; set; }
```

## See Also

* class [AggregateGroup](../AggregateGroup.md)