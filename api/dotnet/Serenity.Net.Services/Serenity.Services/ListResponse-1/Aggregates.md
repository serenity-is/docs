# ListResponse&lt;T&gt;.Aggregates property

The aggregates of all the rows the request matches, and of their groups, when [`Aggregates`](../ListRequest/Aggregates.md) or [`GroupBy`](../ListRequest/GroupBy.md) is requested. It is null when the handler doesn't support aggregates, in which case they can only be calculated from the entities that are returned.

```csharp
public AggregateGroup? Aggregates { get; set; }
```

## See Also

* class [AggregateGroup](../AggregateGroup.md)
* class [ListResponse&lt;T&gt;](../ListResponse-1.md)