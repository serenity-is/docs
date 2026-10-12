# ISqlDialect.SkipKeyword property

Gets the skip keyword.

```csharp
public string SkipKeyword { get; }
```

## Property Value

The skip keyword.

## Remarks

Dialects without a SKIP keyword (check [`CanUseSkipKeyword`](./CanUseSkipKeyword.md) first) throw NotImplementedException.

## See Also

* interface [ISqlDialect](../ISqlDialect.md)