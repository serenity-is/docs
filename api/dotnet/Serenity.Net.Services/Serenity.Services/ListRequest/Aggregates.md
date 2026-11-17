# ListRequest.Aggregates property

The values to calculate from all the rows the request matches, and not only from the page that is returned, e.g. the sum of a field, which are returned in [`Aggregates`](../ListResponse-1/Aggregates.md). A handler that doesn't support aggregates ignores this, and returns none.

```csharp
public List<AggregateBy>? Aggregates { get; set; }
```

## See Also

* class [AggregateBy](../AggregateBy.md)
* class [ListRequest](../ListRequest.md)