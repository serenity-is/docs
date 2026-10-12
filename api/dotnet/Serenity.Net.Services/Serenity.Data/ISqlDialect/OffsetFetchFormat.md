# ISqlDialect.OffsetFetchFormat property

Gets the format for OFFSET FETCH statements.

```csharp
public string OffsetFetchFormat { get; }
```

## Property Value

The offset fetch format.

## Remarks

Dialects without OFFSET support (check [`CanUseOffsetFetch`](./CanUseOffsetFetch.md) first) throw NotImplementedException.

## See Also

* interface [ISqlDialect](../ISqlDialect.md)