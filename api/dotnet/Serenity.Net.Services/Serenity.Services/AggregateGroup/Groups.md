# AggregateGroup.Groups property

The groups of the next level, in their order. It is null for a group of the last level, and at the root when the rows are not grouped, which is also when they are asked to be, but can't.

```csharp
public List<AggregateGroup>? Groups { get; set; }
```

## See Also

* class [AggregateGroup](../AggregateGroup.md)