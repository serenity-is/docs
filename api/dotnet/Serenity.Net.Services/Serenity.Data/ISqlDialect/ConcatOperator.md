# ISqlDialect.ConcatOperator property

Gets the CONCAT operator keyword.

```csharp
public string ConcatOperator { get; }
```

## Property Value

The CONCAT operator keyword.

## Remarks

Dialects without an infix concatenation operator (e.g. MySQL, which concatenates via the `CONCAT()` function) throw NotImplementedException. Check [`CanUseConcat`](./CanUseConcat.md) for `CONCAT()` function support instead; it is independent of this member.

## See Also

* interface [ISqlDialect](../ISqlDialect.md)