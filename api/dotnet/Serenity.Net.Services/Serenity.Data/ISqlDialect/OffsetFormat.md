# ISqlDialect.OffsetFormat property

Gets the format for OFFSET only statements.

```csharp
public string OffsetFormat { get; }
```

## Property Value

The offset format.

## Remarks

Dialects without OFFSET support (check [`CanUseOffsetFetch`](./CanUseOffsetFetch.md) first) throw NotImplementedException.

## See Also

* interface [ISqlDialect](../ISqlDialect.md)