# AggregateGroup.Key property

The value of the group field for the rows of the group, as it is in the entities, so a row can be matched to its group. It is null at the root, and for the group of the rows whose field is null.

```csharp
public object? Key { get; set; }
```

## See Also

* class [AggregateGroup](../AggregateGroup.md)